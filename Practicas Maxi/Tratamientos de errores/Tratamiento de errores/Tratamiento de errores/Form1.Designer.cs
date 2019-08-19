namespace Tratamiento_de_errores
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
            this.EtiNumero = new System.Windows.Forms.Label();
            this.TextBNumero = new System.Windows.Forms.TextBox();
            this.Convertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EtiNumero
            // 
            this.EtiNumero.AutoSize = true;
            this.EtiNumero.Enabled = false;
            this.EtiNumero.Location = new System.Drawing.Point(86, 35);
            this.EtiNumero.Name = "EtiNumero";
            this.EtiNumero.Size = new System.Drawing.Size(100, 13);
            this.EtiNumero.TabIndex = 0;
            this.EtiNumero.Text = "Ingresar un Numero";
            // 
            // TextBNumero
            // 
            this.TextBNumero.Location = new System.Drawing.Point(89, 51);
            this.TextBNumero.Name = "TextBNumero";
            this.TextBNumero.Size = new System.Drawing.Size(150, 20);
            this.TextBNumero.TabIndex = 1;
            // 
            // Convertir
            // 
            this.Convertir.Location = new System.Drawing.Point(126, 87);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(75, 23);
            this.Convertir.TabIndex = 2;
            this.Convertir.Text = "Convertir";
            this.Convertir.UseVisualStyleBackColor = true;
            this.Convertir.Click += new System.EventHandler(this.BtnConvertir);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 152);
            this.Controls.Add(this.Convertir);
            this.Controls.Add(this.TextBNumero);
            this.Controls.Add(this.EtiNumero);
            this.Name = "Menu";
            this.Text = "Manejo de Exepciones";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtiNumero;
        private System.Windows.Forms.TextBox TextBNumero;
        private System.Windows.Forms.Button Convertir;
    }
}

