using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tratamiento_de_errores
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(TextBNumero.Text);
            }
            //Los identificadores de objetos que se utilizan
            //como fe son arbitrarios y solo existen en el ámbito
            //del bloque Catch.
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }
    }
}
