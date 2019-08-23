namespace PRACTICA_9__IMAGELIST_LISTVIEW_
{
    partial class Menu1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            this.GBox1 = new System.Windows.Forms.GroupBox();
            this.RBtnTitulo = new System.Windows.Forms.RadioButton();
            this.RBtnDetalle = new System.Windows.Forms.RadioButton();
            this.RBtnLista = new System.Windows.Forms.RadioButton();
            this.RBtnSmall = new System.Windows.Forms.RadioButton();
            this.RBtnLargel = new System.Windows.Forms.RadioButton();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.LbDicAct = new System.Windows.Forms.Label();
            this.LisVMenu = new System.Windows.Forms.ListView();
            this.ImageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.ImageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.GBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox1
            // 
            this.GBox1.Controls.Add(this.RBtnTitulo);
            this.GBox1.Controls.Add(this.RBtnDetalle);
            this.GBox1.Controls.Add(this.RBtnLista);
            this.GBox1.Controls.Add(this.RBtnSmall);
            this.GBox1.Controls.Add(this.RBtnLargel);
            this.GBox1.Location = new System.Drawing.Point(545, 30);
            this.GBox1.Name = "GBox1";
            this.GBox1.Size = new System.Drawing.Size(200, 263);
            this.GBox1.TabIndex = 1;
            this.GBox1.TabStop = false;
            this.GBox1.Text = "Modo de vista";
            // 
            // RBtnTitulo
            // 
            this.RBtnTitulo.Location = new System.Drawing.Point(61, 180);
            this.RBtnTitulo.Name = "RBtnTitulo";
            this.RBtnTitulo.Size = new System.Drawing.Size(85, 17);
            this.RBtnTitulo.TabIndex = 4;
            this.RBtnTitulo.Text = "Titulo";
            this.RBtnTitulo.UseVisualStyleBackColor = true;
            this.RBtnTitulo.CheckedChanged += new System.EventHandler(this.CheckedChaTitulo);
            // 
            // RBtnDetalle
            // 
            this.RBtnDetalle.Checked = true;
            this.RBtnDetalle.Location = new System.Drawing.Point(61, 140);
            this.RBtnDetalle.Name = "RBtnDetalle";
            this.RBtnDetalle.Size = new System.Drawing.Size(85, 17);
            this.RBtnDetalle.TabIndex = 3;
            this.RBtnDetalle.TabStop = true;
            this.RBtnDetalle.Text = "Detalle";
            this.RBtnDetalle.UseVisualStyleBackColor = true;
            this.RBtnDetalle.CheckedChanged += new System.EventHandler(this.CheckedChaDetalle);
            // 
            // RBtnLista
            // 
            this.RBtnLista.Location = new System.Drawing.Point(61, 100);
            this.RBtnLista.Name = "RBtnLista";
            this.RBtnLista.Size = new System.Drawing.Size(85, 17);
            this.RBtnLista.TabIndex = 2;
            this.RBtnLista.Text = "Lista";
            this.RBtnLista.UseVisualStyleBackColor = true;
            this.RBtnLista.CheckedChanged += new System.EventHandler(this.CheckedChaLista);
            // 
            // RBtnSmall
            // 
            this.RBtnSmall.Location = new System.Drawing.Point(61, 60);
            this.RBtnSmall.Name = "RBtnSmall";
            this.RBtnSmall.Size = new System.Drawing.Size(85, 17);
            this.RBtnSmall.TabIndex = 1;
            this.RBtnSmall.Text = "Small con";
            this.RBtnSmall.UseVisualStyleBackColor = true;
            this.RBtnSmall.CheckedChanged += new System.EventHandler(this.CheckedChaSmall);
            // 
            // RBtnLargel
            // 
            this.RBtnLargel.Location = new System.Drawing.Point(61, 20);
            this.RBtnLargel.Name = "RBtnLargel";
            this.RBtnLargel.Size = new System.Drawing.Size(104, 24);
            this.RBtnLargel.TabIndex = 0;
            this.RBtnLargel.Text = "Large con";
            this.RBtnLargel.UseVisualStyleBackColor = true;
            this.RBtnLargel.CheckedChanged += new System.EventHandler(this.CheckedChaLarge);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(218, 310);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 23);
            this.BtnAtras.TabIndex = 3;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtrasClick);
            // 
            // LbDicAct
            // 
            this.LbDicAct.Enabled = false;
            this.LbDicAct.Location = new System.Drawing.Point(12, 9);
            this.LbDicAct.Name = "LbDicAct";
            this.LbDicAct.Size = new System.Drawing.Size(501, 18);
            this.LbDicAct.TabIndex = 4;
            this.LbDicAct.UseMnemonic = false;
            // 
            // LisVMenu
            // 
            this.LisVMenu.LargeImageList = this.ImageListLarge;
            this.LisVMenu.Location = new System.Drawing.Point(12, 30);
            this.LisVMenu.Name = "LisVMenu";
            this.LisVMenu.Size = new System.Drawing.Size(501, 263);
            this.LisVMenu.SmallImageList = this.ImageListSmall;
            this.LisVMenu.TabIndex = 5;
            this.LisVMenu.UseCompatibleStateImageBehavior = false;
            this.LisVMenu.View = System.Windows.Forms.View.Details;
            this.LisVMenu.ItemActivate += new System.EventHandler(this.LisVMenu_ItemActivate);
            this.LisVMenu.SelectedIndexChanged += new System.EventHandler(this.LisVMenu_SelectedIndexChanged);
            // 
            // ImageListLarge
            // 
            this.ImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListLarge.ImageStream")));
            this.ImageListLarge.TransparentColor = System.Drawing.Color.Black;
            this.ImageListLarge.Images.SetKeyName(0, "_0013_Ember.png");
            this.ImageListLarge.Images.SetKeyName(1, "_0006_Cargo.png");
            this.ImageListLarge.Images.SetKeyName(2, "_0018_Playstation.png");
            this.ImageListLarge.Images.SetKeyName(3, "_0019_Steam.png");
            this.ImageListLarge.Images.SetKeyName(4, "_0023_MobileMe.png");
            // 
            // ImageListSmall
            // 
            this.ImageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListSmall.ImageStream")));
            this.ImageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageListSmall.Images.SetKeyName(0, "aimp.ico");
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.LbDicAct);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.GBox1);
            this.Controls.Add(this.LisVMenu);
            this.Name = "Menu1";
            this.Text = "LISTVIEW";
            this.GBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBox1;
        private System.Windows.Forms.RadioButton RBtnTitulo;
        private System.Windows.Forms.RadioButton RBtnDetalle;
        private System.Windows.Forms.RadioButton RBtnLista;
        private System.Windows.Forms.RadioButton RBtnSmall;
        private System.Windows.Forms.RadioButton RBtnLargel;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Label LbDicAct;
        private System.Windows.Forms.ListView LisVMenu;
        private System.Windows.Forms.ImageList ImageListSmall;
        private System.Windows.Forms.ImageList ImageListLarge;
    }
}

