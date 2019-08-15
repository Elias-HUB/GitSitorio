using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void ValNumeros(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

			{ e.Handled = true;
				return;
			}
		}

			private void ValLetras(object sender, KeyPressEventArgs e)
		{

			if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
				e.Handled = true;
				return;
			}
		}
		private void ValLetNum(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && !(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 32))
			{
				e.Handled = true;
				return;
			}
		}

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void MAceptar(object sender, EventArgs e)
        {
            TexApellido.Text = TexApellido.Text.ToString().ToUpper();
            TexDireccion.Text = TexDireccion.Text.ToString().ToUpper();
            TexEdad.Text = TexEdad.Text.ToString().ToUpper();
            TexNombre.Text = TexNombre.Text.ToString().ToUpper();
            if (TexApellido.BackColor == Color.Red)
                {
                    TexApellido.BackColor = System.Drawing.SystemColors.Control;
                }
            if (TexDireccion.BackColor == Color.Red)
                {
                    TexDireccion.BackColor = System.Drawing.SystemColors.Control;
                }
            if (TexEdad.BackColor == Color.Red)
                {
                    TexEdad.BackColor = System.Drawing.SystemColors.Control;
                }
            if (TexNombre.BackColor == Color.Red)
                {
                    TexNombre.BackColor = System.Drawing.SystemColors.Control;
                }
            if (TexApellido.Text == "")
                {
                    TexApellido.BackColor = Color.Red;
                }
            if (TexDireccion.Text == "")
                {
                    TexDireccion.BackColor = Color.Red;
                }
            if (TexEdad.Text == "")
                {
                    TexEdad.BackColor = Color.Red;
                }
            if (TexNombre.Text == "")
                {
                    TexNombre.BackColor = Color.Red;
                }
            if (TexApellido.Text != "" && TexApellido.BackColor != Color.Red &&
                TexDireccion.Text != "" && TexDireccion.BackColor != Color.Red &&
                TexEdad.Text != "" && TexEdad.BackColor != Color.Red &&
                TexNombre.Text != "" && TexNombre.BackColor != Color.Red
               )
            {
                TexResultado.Text = ("Apellido y Nombre: " + TexApellido.Text + " " + TexNombre.Text + "\r\n" +
                                "Edad: " + TexEdad.Text + "\r\n" +
                                "Dirección: " + TexDireccion.Text);
                TexResultado.Text = TexResultado.Text.ToString().ToUpper();
            }
        }
        private void Mcancelar(object sender, EventArgs e)
        {
            //Application.Exit ();
            this.Close();
        }

        private void PonerBlanco(object sender, EventArgs e)
        {

        }

        private void PonerBlancoA(object sender, EventArgs e)
        {
            if (TexApellido.BackColor == Color.Red)
            {
                TexApellido.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void PonerBlancoN(object sender, EventArgs e)
        {
            if (TexNombre.BackColor == Color.Red)
            {
                TexNombre.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void PonerBlancoE(object sender, EventArgs e)
        {
            if (TexEdad.BackColor == Color.Red)
            {
                TexEdad.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void PonerBlancoD(object sender, EventArgs e)
        {
            if (TexDireccion.BackColor == Color.Red)
            {
                TexDireccion.BackColor = System.Drawing.SystemColors.Control;
            }
        }
    }
}
