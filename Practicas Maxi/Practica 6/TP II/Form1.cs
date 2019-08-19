using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_II
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Deshabilito el Botón Ok.
            BOk.Enabled = false;
        }
        private void ValidarOk()
        {
            //Habilita el Botón, siempre y cuando txtNombre tenga datos.
            BOk.Enabled = (TBoxNombre.BackColor != Color.Red);
        }

        private void Validat(object sender, CancelEventArgs e)
        {
            TextBox Pru = (TextBox)sender;
            if (Pru.Text.Length == 0)   
                Pru.BackColor = Color.Red;
            else
                Pru.BackColor = System.Drawing.SystemColors.Window;


            ValidarOk();

        }

        private void BOk_Click(object sender, EventArgs e)
        {
            string Salida;
            Salida = "Nombre: " + TBoxNombre.Text + "\r\n";
            Salida += "Ocupación: " + (string)(CBProgramador.Checked ?
                        "Programador" : "No es Programador") + "\r\n";
            Salida += "Sexo: " + (string)(SexoH.Checked ? "Hombre" :
                        "Mujer") + "\r\n";

            TextBSalida.Text = Salida;
        }
    }
}
