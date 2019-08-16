namespace LISTBOX_Y_CHECKEDLISTBOX
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxNumeros = new System.Windows.Forms.ListBox();
            this.BtnMover = new System.Windows.Forms.Button();
            this.checkListBoxNumeros = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ListBoxNumeros
            // 
            this.ListBoxNumeros.FormattingEnabled = true;
            this.ListBoxNumeros.Location = new System.Drawing.Point(488, 12);
            this.ListBoxNumeros.Name = "ListBoxNumeros";
            this.ListBoxNumeros.Size = new System.Drawing.Size(300, 329);
            this.ListBoxNumeros.TabIndex = 0;
            // 
            // BtnMover
            // 
            this.BtnMover.Location = new System.Drawing.Point(360, 163);
            this.BtnMover.Name = "BtnMover";
            this.BtnMover.Size = new System.Drawing.Size(75, 23);
            this.BtnMover.TabIndex = 1;
            this.BtnMover.Text = "Mover";
            this.BtnMover.UseVisualStyleBackColor = true;
            this.BtnMover.Click += new System.EventHandler(this.EventBtnMover);
            // 
            // checkListBoxNumeros
            // 
            this.checkListBoxNumeros.CheckOnClick = true;
            this.checkListBoxNumeros.FormattingEnabled = true;
            this.checkListBoxNumeros.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinco",
            "Seis",
            "Siete",
            "Ocho",
            "Nueve"});
            this.checkListBoxNumeros.Location = new System.Drawing.Point(12, 12);
            this.checkListBoxNumeros.Name = "checkListBoxNumeros";
            this.checkListBoxNumeros.Size = new System.Drawing.Size(300, 334);
            this.checkListBoxNumeros.TabIndex = 2;
            this.checkListBoxNumeros.SelectedIndexChanged += new System.EventHandler(this.checkListBoxNumeros_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.checkListBoxNumeros);
            this.Controls.Add(this.BtnMover);
            this.Controls.Add(this.ListBoxNumeros);
            this.Name = "Menu";
            this.Text = "LISTBOX Y CHECKEDLISTBOX";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxNumeros;
        private System.Windows.Forms.Button BtnMover;
        private System.Windows.Forms.CheckedListBox checkListBoxNumeros;
    }
}

