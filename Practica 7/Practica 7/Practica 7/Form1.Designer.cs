namespace Practica_7
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
            this.Negrita = new System.Windows.Forms.Button();
            this.Subrayado = new System.Windows.Forms.Button();
            this.Cursiva = new System.Windows.Forms.Button();
            this.Centrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBFuente = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Abrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Negrita
            // 
            this.Negrita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Negrita.Location = new System.Drawing.Point(36, 30);
            this.Negrita.Name = "Negrita";
            this.Negrita.Size = new System.Drawing.Size(75, 23);
            this.Negrita.TabIndex = 0;
            this.Negrita.Text = "Negrita";
            this.Negrita.UseVisualStyleBackColor = true;
            this.Negrita.Click += new System.EventHandler(this.BtnNegrita);
            // 
            // Subrayado
            // 
            this.Subrayado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Subrayado.Location = new System.Drawing.Point(212, 30);
            this.Subrayado.Name = "Subrayado";
            this.Subrayado.Size = new System.Drawing.Size(75, 23);
            this.Subrayado.TabIndex = 1;
            this.Subrayado.Text = "Subrayado";
            this.Subrayado.UseVisualStyleBackColor = true;
            this.Subrayado.Click += new System.EventHandler(this.BtnSubrayado);
            // 
            // Cursiva
            // 
            this.Cursiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cursiva.Location = new System.Drawing.Point(397, 30);
            this.Cursiva.Name = "Cursiva";
            this.Cursiva.Size = new System.Drawing.Size(75, 23);
            this.Cursiva.TabIndex = 2;
            this.Cursiva.Text = "Cursiva";
            this.Cursiva.UseVisualStyleBackColor = true;
            this.Cursiva.Click += new System.EventHandler(this.BtnCursiva);
            // 
            // Centrado
            // 
            this.Centrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Centrado.Location = new System.Drawing.Point(608, 30);
            this.Centrado.Name = "Centrado";
            this.Centrado.Size = new System.Drawing.Size(75, 23);
            this.Centrado.TabIndex = 3;
            this.Centrado.Text = "Centrado";
            this.Centrado.UseVisualStyleBackColor = true;
            this.Centrado.Click += new System.EventHandler(this.BtnCentrar);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(237, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tamaño Fuente";
            // 
            // TextBFuente
            // 
            this.TextBFuente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBFuente.Location = new System.Drawing.Point(334, 92);
            this.TextBFuente.MaxLength = 2;
            this.TextBFuente.Name = "TextBFuente";
            this.TextBFuente.Size = new System.Drawing.Size(89, 20);
            this.TextBFuente.TabIndex = 5;
            this.TextBFuente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTamanio);
            this.TextBFuente.Validated += new System.EventHandler(this.Validador);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(43, 133);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(645, 97);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            this.richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.LC);
            // 
            // Guardar
            // 
            this.Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardar.Location = new System.Drawing.Point(226, 254);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.ClickGuardar);
            // 
            // Abrir
            // 
            this.Abrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Abrir.Location = new System.Drawing.Point(397, 254);
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(75, 23);
            this.Abrir.TabIndex = 8;
            this.Abrir.Text = "Abrir";
            this.Abrir.UseVisualStyleBackColor = true;
            this.Abrir.Click += new System.EventHandler(this.ClickAbrir);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(717, 289);
            this.Controls.Add(this.Abrir);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.TextBFuente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Centrado);
            this.Controls.Add(this.Cursiva);
            this.Controls.Add(this.Subrayado);
            this.Controls.Add(this.Negrita);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(733, 328);
            this.Name = "Menu";
            this.Text = "RICHTEXTBOX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Negrita;
        private System.Windows.Forms.Button Subrayado;
        private System.Windows.Forms.Button Cursiva;
        private System.Windows.Forms.Button Centrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBFuente;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Abrir;
    }
}

