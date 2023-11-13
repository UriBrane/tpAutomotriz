using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpAutomotrizFront.Servicios
{
    public class Validador
    {
        // CLASE QUE SIRVE PARA VALIDAR EL CONTENIDO DE LOS CONTROLES

        public static Validador? instance;
        private Validador() { }
        public static Validador GetInstance()
        {
            if (instance == null)
                instance = new Validador();
            return instance;
        }

        public bool ValidarString(string s, Control c)
        { //Valida si el contenido de un control es STRING, y sino lo es larga un mensaje y hace focus en el control
            bool aux = true;
            if (string.IsNullOrWhiteSpace(s))
                aux = false;
            if (s.Length > 100)
                aux = false;
            if (!aux)
            {
                MessageBox.Show("El contenido a guardar no es valido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                c.Focus();
            }
            return aux;
        }
        public bool ValidarInt(string s, Control c)
        { //Valida si el contenido de un control es INT, y sino lo es larga un mensaje y hace focus en el control
            bool aux = true;
            if (!int.TryParse(s, out _))
                aux = false;
            if (!aux)
            {
                MessageBox.Show("El contenido a guardar no es valido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                c.Focus();
            }
            return aux;
        }
        public bool ValidarLong(string s, Control c)
        {
            // Valida si el contenido de un control es LONG, y si no lo es, muestra un mensaje y hace focus en el control
            bool aux = true;
            if (!long.TryParse(s, out _))
                aux = false;
            if (!aux)
            {
                MessageBox.Show("El contenido a guardar no es valido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                c.Focus();
            }
            return aux;
        }

        public bool ValidarDouble(string s, Control c)
        {
            bool aux = true;
            if (!double.TryParse(s, out _)) 
                aux = false;
            if(!aux)
            {
                MessageBox.Show("El contenido a guardar no es valido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                c.Focus();
            }
            return aux;
        }
        public bool ValidarCombo(ComboBox c)
        {
            bool aux = true;
            if (c.SelectedIndex == -1)
                aux = false;
            if (!aux)
            {
                MessageBox.Show("Seleccione una opción de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                c.Focus();
            }
            return aux;
        }
    }
}
