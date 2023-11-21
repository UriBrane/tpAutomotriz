using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpAutomotrizBack.Datos;
using TpAutomotrizBack.Entidades;

namespace TpAutomotrizFront.Presentacion
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
            configCombo();
            txtSentencia.ScrollBars = ScrollBars.Both;
            txtSql.ScrollBars = ScrollBars.Both;
            confParam(false, 3);
        }

        private void confParam(bool x, int y)
        {
            label2.Visible = x;
            label3.Visible = x;
            txtP1.Visible = x;
            txtP2.Visible = x;
            button1.Visible = x;
            if (y == 1)
            {
                txtP2.Visible = !x;
                label3.Visible = !x;
                label2.Text = "Valor";
            }
            if (y == 2)
            {
                label2.Text = "Año";
                label3.Text = "Mes";
            }
        }

        private void configCombo()
        {
            cboConsulta.Items.Add("Consulta Descuentos");
            cboConsulta.Items.Add("Consulta Ventas");
            cboConsulta.Items.Add("Consulta Productos");
            cboConsulta.Items.Add("Consulta Clientes");
            cboConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboConsulta.SelectedIndex == 0)
            {
                confParam(false, 3);
                consultaDescuento();
            }
            if (cboConsulta.SelectedIndex == 1)
            {
                consultaVentas();
                confParam(false, 3);
            }
            if (cboConsulta.SelectedIndex == 2)
            {
                consultaProductos();
                confParam(true, 2);
            }
            if (cboConsulta.SelectedIndex == 3)
            {
                consultaClientes();
                confParam(true, 1);
            }
        }

        private void consultaClientes()
        {
            txtSentencia.Text = "Listar aquellos clientes, los cuales con la suma de todas sus compras en los ultimos 3 años, hayan superado el valor ingresado por parametro";
            txtSql.Text = "CREATE PROCEDURE SP_CONSULTA_ESTADISTICAS_VENDEDORES\r\n    @total_facturado DECIMAL(25, 2)\r\nAS\r\nBEGIN\r\n    SELECT\r\n        f.id_cliente AS Id,\r\n        c.apellido + ', ' + c.nombre AS Nombre,\r\n        COUNT(f.id_factura) AS 'Cantidad de Compras',\r\n        SUM(df.Cantidad) AS 'Productos comprados',\r\n        SUM(df.cantidad * df.precio) AS 'Total Facturado'\r\n    FROM clientes c\r\n    JOIN Facturas f ON f.id_cliente = c.id_cliente\r\n    JOIN Detalles_Facturas df ON df.id_factura = f.id_factura\r\n    WHERE DATEDIFF(YEAR, f.fecha, GETDATE()) <= 3\r\n    GROUP BY f.id_cliente, c.apellido + ', ' + c.nombre\r\n    HAVING SUM(df.cantidad * df.precio) > @total_facturado;\r\nEND\r\nGO\r\n\r\n\t\r\n\t\r\n\tEXEC SP_CONSULTA_DESCUENTOS_PROMEDIO;\r\n\tEXEC SP_CONSULTA_VENTAS_TOTALES;\r\n\texec SP_CONSULTA_ESTADO_PRODUCTOS2 2022,05;\r\n\tEXEC SP_CONSULTA_ESTADISTICAS_VENDEDORES @total_facturado = 50000.00;\r\n\r\nGO";

        }

        private void consultaProductos()
        {
            txtSentencia.Text = "Listar una misma tabla de resultados, una lista completa de los productos, junto con su estado de venta: vendido o no vendido, durante el año y el mes ingresado por parametros";
            txtSql.Text = "CREATE PROCEDURE SP_CONSULTA_ESTADO_PRODUCTOS\r\n@año int,\r\n@mes int\r\nAS\r\nBEGIN\r\n    -- Productos vendidos\r\n    SELECT\r\n        p.id_producto,\r\n        p.descripcion,\r\n        'Vendido' AS estado\r\n    FROM\r\n        Detalles_Facturas df\r\n    JOIN\r\n        Productos p ON df.id_producto = p.id_producto\r\n\tjoin\r\n\tFacturas f on f.id_factura=df.id_factura\r\n\twhere\r\n\tyear(f.fecha)=@año and month(f.fecha)=@mes\r\n\r\n    UNION\r\n\r\n    -- Productos no vendidos\r\n    SELECT\r\n        p.id_producto,\r\n        p.descripcion,\r\n        'No Vendido' AS estado\r\n     FROM\r\n        Detalles_Facturas df\r\n    JOIN\r\n        Productos p ON df.id_producto = p.id_producto\r\n\tjoin\r\n\tFacturas f on f.id_factura=df.id_factura\r\n    WHERE\r\n        p.id_producto NOT IN (\r\n            SELECT DISTINCT id_producto\r\n            FROM Detalles_Facturas\r\n\t\t\twhere year(f.fecha)=@año and month(f.fecha)=@mes\r\n        ) \r\nEND;\r\ngo";


        }

        private void consultaVentas()
        {
            txtSentencia.Text = "Listar los vendedores cuyas ventas totales sean superiores al promedio general";
            txtSql.Text = "CREATE PROCEDURE SP_CONSULTA_VENTAS_TOTALES\r\nAS\r\nBEGIN\r\n    SELECT\r\n        v.id_vendedor,\r\n        v.nombre + ', ' + v.apellido AS 'Vendedor',\r\n        SUM(df.cantidad * df.precio) AS 'VentasTotales'\r\n    FROM\r\n        Vendedores v\r\n    JOIN\r\n        Facturas f ON v.id_vendedor = f.id_vendedor\r\n    JOIN\r\n        Detalles_Facturas df ON f.id_factura = df.id_factura\r\n    GROUP BY\r\n        v.id_vendedor,\r\n        v.nombre,\r\n        v.apellido\r\n    HAVING\r\n        SUM(df.cantidad * df.precio) > (\r\n            SELECT AVG(VentasTotales)\r\n            FROM (\r\n                SELECT\r\n                    SUM(df1.cantidad * df1.precio) AS 'VentasTotales'\r\n                FROM\r\n                    Facturas f1\r\n                JOIN\r\n                    Detalles_Facturas df1 ON f1.id_factura = df1.id_factura\r\n                GROUP BY\r\n                    f1.id_vendedor\r\n            ) AS subconsulta\r\n        );\r\nEND;\r\ngo";



            DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SP_CONSULTA_VENTAS_TOTALES");

            dgvConsulta.DataSource = dt;
        }

        private void consultaDescuento()
        {
            txtSentencia.Text = "Determinar el descuento promedio realizado por vendedor con una antigüedad mayor o igual al año a cada cliente que haya realizado compras con tarjeta de crédito. Mostrar el total comprado y el descuento agrupándolos por clientes, vendedores y la categoría de estos últimos. Solo mostrar la info si hubieron descuentos realizados y ordenar de mayor a menor el promedio descuento.";
            txtSql.Text = "CREATE PROCEDURE SP_CONSULTA_DESCUENTOS_PROMEDIO\r\nAS\r\nBEGIN\r\n    SELECT\r\n        c.id_cliente,\r\n        c.nombre + ', ' + c.apellido AS 'cliente',\r\n        v.nombre + ', ' + v.apellido AS 'vendedor',\r\n        DATEDIFF(YEAR, v.fecha_ingreso, GETDATE()) AS 'Antigüedad',\r\n        SUM(((p.cantidad * p.precio) / 100) * d.porcentaje) AS 'Descuento',\r\n        AVG(d.porcentaje) AS 'Promedio_Descuento',\r\n        cat.descripcion AS 'Categoria'\r\n    FROM\r\n        Clientes c\r\n    JOIN\r\n        Facturas f ON f.id_cliente = c.id_cliente\r\n    JOIN\r\n        Detalles_Facturas df ON f.id_factura = df.id_factura\r\n    JOIN\r\n        Vendedores v ON f.id_vendedor = v.id_vendedor\r\n    JOIN\r\n        Descuentos d ON d.id_descuento = df.id_descuento\r\n    JOIN\r\n        Formas_Pago fp ON f.id_forma_pago = fp.id_forma_pago\r\n    JOIN\r\n        Categorias cat ON v.id_categoria = cat.id_categoria\r\n    JOIN\r\n        Productos p ON p.id_producto = df.id_producto\r\n    WHERE\r\n        f.id_forma_pago IN (\r\n            SELECT\r\n                id_forma_pago\r\n            FROM\r\n                Facturas ff\r\n            JOIN\r\n                Vendedores vv ON ff.id_vendedor = vv.id_vendedor\r\n            WHERE\r\n                DATEDIFF(YEAR, vv.fecha_ingreso, GETDATE()) >= 1\r\n        )\r\n    GROUP BY\r\n        c.id_cliente,\r\n        c.nombre,\r\n        c.apellido,\r\n        v.nombre,\r\n        v.apellido,\r\n        v.fecha_ingreso,\r\n        cat.descripcion,\r\n        f.id_factura\r\n    HAVING\r\n        AVG(d.porcentaje) IS NOT NULL\r\n    ORDER BY\r\n        'Promedio_Descuento' ASC;\r\nEND;\r\n\r\ngo";

            DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SP_CONSULTA_DESCUENTOS_PROMEDIO");

            dgvConsulta.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtP2.Visible == false)
            {
                if (txtP1.Text == "")
                {
                    MessageBox.Show("Faltan parametros!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SP_CONSULTA_ESTADISTICAS_VENDEDORES", "@total_facturado", Convert.ToInt32(txtP1.Text));

                dgvConsulta.DataSource = dt;
            }
            if (txtP2.Visible == true)
            {
                if (txtP1.Text == "" || txtP2.Text == "")
                {
                    MessageBox.Show("Faltan parametros!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                List<Parametro> lista = new List<Parametro>();
                lista.Add(new Parametro("@año", Convert.ToInt32(txtP1.Text)));
                lista.Add(new Parametro("@mes", Convert.ToInt32(txtP2.Text)));

                DataTable dt = HelperDAO.GetInstance().ConsultarTabla("SP_CONSULTA_ESTADO_PRODUCTOS", lista);

                dgvConsulta.DataSource = dt;
            }
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
