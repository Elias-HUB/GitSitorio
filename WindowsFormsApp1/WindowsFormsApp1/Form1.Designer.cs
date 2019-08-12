namespace WindowsFormsApp1
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
			this.Apellido = new System.Windows.Forms.TextBox();
			this.Nombre = new System.Windows.Forms.TextBox();
			this.Edad = new System.Windows.Forms.TextBox();
			this.Direccion = new System.Windows.Forms.TextBox();
			this.Resultado = new System.Windows.Forms.TextBox();
			this.TexApellido = new System.Windows.Forms.TextBox();
			this.TexNombre = new System.Windows.Forms.TextBox();
			this.TexEdad = new System.Windows.Forms.TextBox();
			this.TexDireccion = new System.Windows.Forms.TextBox();
			this.TexResultado = new System.Windows.Forms.TextBox();
			this.MenuCancelar = new System.Windows.Forms.Button();
			this.MenuAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Apellido
			// 
			this.Apellido.BackColor = System.Drawing.Color.Tan;
			this.Apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Apellido.Cursor = System.Windows.Forms.Cursors.Default;
			this.Apellido.Enabled = false;
			this.Apellido.Location = new System.Drawing.Point(13, 15);
			this.Apellido.Margin = new System.Windows.Forms.Padding(4);
			this.Apellido.Name = "Apellido";
			this.Apellido.Size = new System.Drawing.Size(83, 15);
			this.Apellido.TabIndex = 0;
			this.Apellido.TabStop = false;
			this.Apellido.Text = "APELLIDO";
			// 
			// Nombre
			// 
			this.Nombre.BackColor = System.Drawing.Color.Tan;
			this.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Nombre.Enabled = false;
			this.Nombre.Location = new System.Drawing.Point(13, 40);
			this.Nombre.Margin = new System.Windows.Forms.Padding(4);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(83, 15);
			this.Nombre.TabIndex = 1;
			this.Nombre.Text = "NOMBRE";
			// 
			// Edad
			// 
			this.Edad.BackColor = System.Drawing.Color.Tan;
			this.Edad.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Edad.Enabled = false;
			this.Edad.Location = new System.Drawing.Point(13, 65);
			this.Edad.Margin = new System.Windows.Forms.Padding(4);
			this.Edad.Name = "Edad";
			this.Edad.Size = new System.Drawing.Size(83, 15);
			this.Edad.TabIndex = 2;
			this.Edad.Text = "EDAD";
			// 
			// Direccion
			// 
			this.Direccion.BackColor = System.Drawing.Color.Tan;
			this.Direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Direccion.Enabled = false;
			this.Direccion.Location = new System.Drawing.Point(13, 90);
			this.Direccion.Margin = new System.Windows.Forms.Padding(4);
			this.Direccion.Name = "Direccion";
			this.Direccion.Size = new System.Drawing.Size(83, 15);
			this.Direccion.TabIndex = 3;
			this.Direccion.Text = "DIRECCIÓN";
			// 
			// Resultado
			// 
			this.Resultado.BackColor = System.Drawing.Color.Tan;
			this.Resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Resultado.Enabled = false;
			this.Resultado.Location = new System.Drawing.Point(13, 128);
			this.Resultado.Margin = new System.Windows.Forms.Padding(4);
			this.Resultado.Name = "Resultado";
			this.Resultado.Size = new System.Drawing.Size(83, 15);
			this.Resultado.TabIndex = 4;
			this.Resultado.Text = "RESULTADO";
			// 
			// TexApellido
			// 
			this.TexApellido.Location = new System.Drawing.Point(103, 12);
			this.TexApellido.MaxLength = 20;
			this.TexApellido.Name = "TexApellido";
			this.TexApellido.Size = new System.Drawing.Size(265, 22);
			this.TexApellido.TabIndex = 5;
			this.TexApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValLetras);
			// 
			// TexNombre
			// 
			this.TexNombre.Location = new System.Drawing.Point(103, 37);
			this.TexNombre.MaxLength = 20;
			this.TexNombre.Name = "TexNombre";
			this.TexNombre.Size = new System.Drawing.Size(265, 22);
			this.TexNombre.TabIndex = 6;
			this.TexNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValLetras);
			// 
			// TexEdad
			// 
			this.TexEdad.Location = new System.Drawing.Point(103, 62);
			this.TexEdad.MaxLength = 3;
			this.TexEdad.Name = "TexEdad";
			this.TexEdad.Size = new System.Drawing.Size(44, 22);
			this.TexEdad.TabIndex = 7;
			this.TexEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValNumeros);
			// 
			// TexDireccion
			// 
			this.TexDireccion.Location = new System.Drawing.Point(103, 87);
			this.TexDireccion.MaxLength = 60;
			this.TexDireccion.Name = "TexDireccion";
			this.TexDireccion.Size = new System.Drawing.Size(265, 22);
			this.TexDireccion.TabIndex = 8;
			this.TexDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValLetNum);
			// 
			// TexResultado
			// 
			this.TexResultado.Enabled = false;
			this.TexResultado.Location = new System.Drawing.Point(13, 150);
			this.TexResultado.MaxLength = 250;
			this.TexResultado.Multiline = true;
			this.TexResultado.Name = "TexResultado";
			this.TexResultado.Size = new System.Drawing.Size(355, 96);
			this.TexResultado.TabIndex = 9;
			this.TexResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValLetNum);
			// 
			// MenuCancelar
			// 
			this.MenuCancelar.Location = new System.Drawing.Point(214, 265);
			this.MenuCancelar.Name = "MenuCancelar";
			this.MenuCancelar.Size = new System.Drawing.Size(75, 23);
			this.MenuCancelar.TabIndex = 11;
			this.MenuCancelar.Text = "Cancelar";
			this.MenuCancelar.UseVisualStyleBackColor = true;
			// 
			// MenuAceptar
			// 
			this.MenuAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.MenuAceptar.Location = new System.Drawing.Point(87, 265);
			this.MenuAceptar.Name = "MenuAceptar";
			this.MenuAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.MenuAceptar.Size = new System.Drawing.Size(75, 23);
			this.MenuAceptar.TabIndex = 12;
			this.MenuAceptar.Text = "Aceptar";
			this.MenuAceptar.UseVisualStyleBackColor = true;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(381, 311);
			this.Controls.Add(this.MenuAceptar);
			this.Controls.Add(this.MenuCancelar);
			this.Controls.Add(this.TexResultado);
			this.Controls.Add(this.TexDireccion);
			this.Controls.Add(this.TexEdad);
			this.Controls.Add(this.TexNombre);
			this.Controls.Add(this.TexApellido);
			this.Controls.Add(this.Resultado);
			this.Controls.Add(this.Direccion);
			this.Controls.Add(this.Edad);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.Apellido);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Datos Personales";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Apellido;
		private System.Windows.Forms.TextBox Nombre;
		private System.Windows.Forms.TextBox Edad;
		private System.Windows.Forms.TextBox Direccion;
		private System.Windows.Forms.TextBox Resultado;
		private System.Windows.Forms.TextBox TexApellido;
		private System.Windows.Forms.TextBox TexNombre;
		private System.Windows.Forms.TextBox TexEdad;
		private System.Windows.Forms.TextBox TexDireccion;
		private System.Windows.Forms.TextBox TexResultado;
		private System.Windows.Forms.Button MenuCancelar;
		private System.Windows.Forms.Button MenuAceptar;
	}
}

