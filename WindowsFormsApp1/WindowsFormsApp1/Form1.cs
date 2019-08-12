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
	}
}
