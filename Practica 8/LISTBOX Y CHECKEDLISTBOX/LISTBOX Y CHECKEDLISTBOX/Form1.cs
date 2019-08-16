using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTBOX_Y_CHECKEDLISTBOX
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            checkListBoxNumeros.Items.Add("Diez");
        }
        private void checkListBoxNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EventBtnMover(object sender, EventArgs e)
        {
            //Pregunta si la cantidad (Count) de elementos chequeados
            //en la colección de ítems chequeados(CheckedItems) es mayor a cero.
            if (checkListBoxNumeros.CheckedItems.Count > 0)
            {
                //Si es mayor a cero. Limpia los Ítem en el ListBox.
                ListBoxNumeros.Items.Clear();

                //La sentencia foreach recorre la colección de Ítems Seleccionados
                //Y los asigna de a uno a la variable ítem del tipo String.
                foreach (string item in checkListBoxNumeros.CheckedItems)
                {
                    //Agrego los ítems seleccionados en la colección
                    //Al Listbox con el Método Add.
                    ListBoxNumeros.Items.Add(item.ToString());
                }
                //Recorro todos los Ítems del CheckedListBox.
                for (int i = 0; i < checkListBoxNumeros.Items.Count; i++)
                    //Con el Método SetItemChecked, establezco en falso la
                    //casilla de verificación (No esta seleccionado).
                    //Como parámetros i-El índice y el valor de estado en este caso false.
                    checkListBoxNumeros.SetItemChecked(i, false);
            }
        }
    }
}
