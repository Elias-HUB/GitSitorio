namespace TP_II
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
            this.TBoxNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.BOk = new System.Windows.Forms.Button();
            this.CBProgramador = new System.Windows.Forms.CheckBox();
            this.SexiM = new System.Windows.Forms.RadioButton();
            this.SexoH = new System.Windows.Forms.RadioButton();
            this.GroupBSexo = new System.Windows.Forms.GroupBox();
            this.Salida = new System.Windows.Forms.Label();
            this.TextBSalida = new System.Windows.Forms.TextBox();
            this.GroupBSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBoxNombre
            // 
            this.TBoxNombre.Location = new System.Drawing.Point(62, 6);
            this.TBoxNombre.Name = "TBoxNombre";
            this.TBoxNombre.Size = new System.Drawing.Size(310, 20);
            this.TBoxNombre.TabIndex = 0;
            this.TBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.Validat);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Enabled = false;
            this.Nombre.Location = new System.Drawing.Point(12, 10);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // BOk
            // 
            this.BOk.Location = new System.Drawing.Point(392, 4);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(75, 23);
            this.BOk.TabIndex = 2;
            this.BOk.Text = "OK";
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // CBProgramador
            // 
            this.CBProgramador.AutoSize = true;
            this.CBProgramador.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBProgramador.Checked = true;
            this.CBProgramador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBProgramador.Location = new System.Drawing.Point(15, 50);
            this.CBProgramador.Name = "CBProgramador";
            this.CBProgramador.Size = new System.Drawing.Size(86, 17);
            this.CBProgramador.TabIndex = 3;
            this.CBProgramador.Text = "Programador";
            this.CBProgramador.UseVisualStyleBackColor = true;
            // 
            // SexiM
            // 
            this.SexiM.AutoSize = true;
            this.SexiM.Location = new System.Drawing.Point(208, 43);
            this.SexiM.Name = "SexiM";
            this.SexiM.Size = new System.Drawing.Size(51, 17);
            this.SexiM.TabIndex = 4;
            this.SexiM.Text = "Mujer";
            this.SexiM.UseVisualStyleBackColor = true;
            // 
            // SexoH
            // 
            this.SexoH.AutoSize = true;
            this.SexoH.Checked = true;
            this.SexoH.Location = new System.Drawing.Point(47, 43);
            this.SexoH.Name = "SexoH";
            this.SexoH.Size = new System.Drawing.Size(62, 17);
            this.SexoH.TabIndex = 5;
            this.SexoH.TabStop = true;
            this.SexoH.Text = "Hombre";
            this.SexoH.UseVisualStyleBackColor = true;
            // 
            // GroupBSexo
            // 
            this.GroupBSexo.Controls.Add(this.SexiM);
            this.GroupBSexo.Controls.Add(this.SexoH);
            this.GroupBSexo.Location = new System.Drawing.Point(15, 90);
            this.GroupBSexo.Name = "GroupBSexo";
            this.GroupBSexo.Size = new System.Drawing.Size(333, 100);
            this.GroupBSexo.TabIndex = 6;
            this.GroupBSexo.TabStop = false;
            this.GroupBSexo.Text = "Sexo";
            // 
            // Salida
            // 
            this.Salida.AutoSize = true;
            this.Salida.Enabled = false;
            this.Salida.Location = new System.Drawing.Point(12, 212);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(36, 13);
            this.Salida.TabIndex = 7;
            this.Salida.Text = "Salida";
            // 
            // TextBSalida
            // 
            this.TextBSalida.Location = new System.Drawing.Point(15, 228);
            this.TextBSalida.Multiline = true;
            this.TextBSalida.Name = "TextBSalida";
            this.TextBSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBSalida.Size = new System.Drawing.Size(333, 59);
            this.TextBSalida.TabIndex = 8;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(474, 309);
            this.Controls.Add(this.TextBSalida);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.GroupBSexo);
            this.Controls.Add(this.CBProgramador);
            this.Controls.Add(this.BOk);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TBoxNombre);
            this.Name = "Menu";
            this.Text = "RADIOBUTTON Y CHECKBOX";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.GroupBSexo.ResumeLayout(false);
            this.GroupBSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBoxNombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.CheckBox CBProgramador;
        private System.Windows.Forms.RadioButton SexiM;
        private System.Windows.Forms.RadioButton SexoH;
        private System.Windows.Forms.GroupBox GroupBSexo;
        private System.Windows.Forms.Label Salida;
        private System.Windows.Forms.TextBox TextBSalida;
    }
}

