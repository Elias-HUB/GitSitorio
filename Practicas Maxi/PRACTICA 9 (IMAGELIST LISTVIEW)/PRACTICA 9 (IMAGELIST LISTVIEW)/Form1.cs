using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_9__IMAGELIST_LISTVIEW_
{
    public partial class Menu1 : Form
    {
        private System.Collections.Specialized.StringCollection carpetacol;
        public Menu1()
        {
            InitializeComponent();
            carpetacol = new System.Collections.Specialized.StringCollection();
            CrearCabecerayLlenarListView();
            DibujarListView(@"C:\");
            carpetacol.Add(@"C:\");
        }
        private void CrearCabecerayLlenarListView()
        {
            ColumnHeader colCab; //Declaro un objeto ColumnHeader.
            colCab = new ColumnHeader(); //Instancio el objeto ColumnHeader.
            colCab.Text = "Nombre Archivo";
            LisVMenu.Columns.Add(colCab); // Inserto la Cabecera Nombre Archivo.
            colCab = new ColumnHeader();
            colCab.Text = "Tamaño";
            LisVMenu.Columns.Add(colCab); // Inserto la Cabecera Tamaño.
            colCab = new ColumnHeader();
            colCab.Text = "Ultima Modificacion";
            LisVMenu.Columns.Add(colCab); // Inserto la Cabecera Ultima Modificacion.
        }

        private void DibujarListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;
                if (string.IsNullOrEmpty(root))
                    return;
                DirectoryInfo dir = new DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                LisVMenu.Items.Clear();
                LbDicAct.Text = root;
                LisVMenu.BeginUpdate();
                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.ImageIndex = 0;
                    lvi.Tag = di.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "";
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    LisVMenu.Items.Add(lvi);
                }
                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = fi.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    LisVMenu.Items.Add(lvi);
                }
                LisVMenu.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }


        private void LisVMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LisVMenu_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(filename);
                }
                catch { return; }
            }
            else
            {
                DibujarListView(filename);
                carpetacol.Add(filename);
            }
        }

        private void BtnAtrasClick(object sender, EventArgs e)
        {
            if (carpetacol.Count > 1)
            {
                DibujarListView(carpetacol[carpetacol.Count - 2].ToString());
                carpetacol.RemoveAt(carpetacol.Count - 1);
            }
            else
                DibujarListView(carpetacol[0].ToString());
        }

        private void CheckedChaLarge(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.LisVMenu.View = View.LargeIcon;
        }

        private void CheckedChaSmall(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                LisVMenu.View = View.SmallIcon;

        }

        private void CheckedChaLista(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                LisVMenu.View = View.List;

        }

        private void CheckedChaDetalle(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                LisVMenu.View = View.Details;

        }

        private void CheckedChaTitulo(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                LisVMenu.View = View.Tile;

        }
    }
}
