using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpAutomotrizBack.Datos;

namespace TpAutomotrizFront.Servicios
{
    public class CargarCombo
    {
        private static CargarCombo? instance;
        private CargarCombo() { }
        public static CargarCombo GetInstance()
        {
            if (instance == null)
                instance = new CargarCombo();
            return instance;
        }

        public void CargarCbo(string nombreSP, ComboBox combo)
        {
            DataTable dt = HelperDAO.GetInstance().ConsultarTabla(nombreSP);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.SelectedIndex = -1;
        }

        public async Task CargarComboAsync<T>(ComboBox cbo, string url, string valueMember, string displayMember)
        {
            var dataJson = await ClientSingleton.GetInstance().GetAsync(url);
            List<T> lst = JsonConvert.DeserializeObject<List<T>>(dataJson);
            cbo.DataSource = lst;
            cbo.ValueMember = valueMember;
            cbo.DisplayMember = displayMember;
            cbo.SelectedIndex = -1;
        }

        public void CargarCboTipoPersona(ComboBox c)
        {
            string[] tipo = { "Cliente", "Vendedor" };
            c.DataSource = tipo;
            c.SelectedIndex = -1;
        }
    }
}
