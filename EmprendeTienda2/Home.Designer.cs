namespace EmprendeTienda
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_productos = new FontAwesome.Sharp.IconButton();
            btn_clientes = new FontAwesome.Sharp.IconButton();
            bnt_ventas = new FontAwesome.Sharp.IconButton();
            btn_localidades = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            btn_salirDelSistema = new FontAwesome.Sharp.IconMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_productos
            // 
            btn_productos.BackColor = Color.RosyBrown;
            btn_productos.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btn_productos.IconColor = Color.AntiqueWhite;
            btn_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_productos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_productos.Location = new Point(177, 208);
            btn_productos.Margin = new Padding(2);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(104, 47);
            btn_productos.TabIndex = 3;
            btn_productos.Text = "Productos";
            btn_productos.TextAlign = ContentAlignment.MiddleRight;
            btn_productos.UseVisualStyleBackColor = false;
            btn_productos.Click += btn_productos_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.BackColor = Color.RosyBrown;
            btn_clientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btn_clientes.IconColor = Color.AntiqueWhite;
            btn_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_clientes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clientes.Location = new Point(177, 284);
            btn_clientes.Margin = new Padding(2);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(104, 47);
            btn_clientes.TabIndex = 4;
            btn_clientes.Text = "Clientes";
            btn_clientes.TextAlign = ContentAlignment.MiddleRight;
            btn_clientes.UseVisualStyleBackColor = false;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // bnt_ventas
            // 
            bnt_ventas.BackColor = Color.RosyBrown;
            bnt_ventas.IconChar = FontAwesome.Sharp.IconChar.CommentDollar;
            bnt_ventas.IconColor = Color.AntiqueWhite;
            bnt_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bnt_ventas.ImageAlign = ContentAlignment.MiddleLeft;
            bnt_ventas.Location = new Point(318, 208);
            bnt_ventas.Margin = new Padding(2);
            bnt_ventas.Name = "bnt_ventas";
            bnt_ventas.Size = new Size(104, 47);
            bnt_ventas.TabIndex = 6;
            bnt_ventas.Text = "Ventas";
            bnt_ventas.TextAlign = ContentAlignment.MiddleRight;
            bnt_ventas.UseVisualStyleBackColor = false;
            bnt_ventas.Click += bnt_ventas_Click;
            // 
            // btn_localidades
            // 
            btn_localidades.BackColor = Color.RosyBrown;
            btn_localidades.IconChar = FontAwesome.Sharp.IconChar.Location;
            btn_localidades.IconColor = Color.AntiqueWhite;
            btn_localidades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_localidades.ImageAlign = ContentAlignment.MiddleLeft;
            btn_localidades.Location = new Point(318, 284);
            btn_localidades.Margin = new Padding(2);
            btn_localidades.Name = "btn_localidades";
            btn_localidades.Size = new Size(104, 47);
            btn_localidades.TabIndex = 7;
            btn_localidades.Text = "Localidad";
            btn_localidades.TextAlign = ContentAlignment.MiddleRight;
            btn_localidades.UseVisualStyleBackColor = false;
            btn_localidades.Click += btn_localidades_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = EmprendeTiendaDesktop.Properties.Resources._;
            pictureBox1.Location = new Point(177, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(622, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(115, 20);
            iconMenuItem1.Text = "Menu Principal";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { btn_salirDelSistema });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(57, 20);
            iconMenuItem2.Text = "Salir";
            // 
            // btn_salirDelSistema
            // 
            btn_salirDelSistema.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btn_salirDelSistema.IconColor = Color.Black;
            btn_salirDelSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_salirDelSistema.Name = "btn_salirDelSistema";
            btn_salirDelSistema.RightToLeftAutoMirrorImage = true;
            btn_salirDelSistema.Size = new Size(158, 22);
            btn_salirDelSistema.Text = "Salir del sistema";
            btn_salirDelSistema.Click += btn_salirDelSistema_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(622, 376);
            Controls.Add(pictureBox1);
            Controls.Add(btn_localidades);
            Controls.Add(bnt_ventas);
            Controls.Add(btn_clientes);
            Controls.Add(btn_productos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emprende Tienda";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_productos;
        private FontAwesome.Sharp.IconButton btn_clientes;
        private FontAwesome.Sharp.IconButton btn_localidades;
        private PictureBox pictureBox1;
        public FontAwesome.Sharp.IconButton bnt_ventas;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem btn_salirDelSistema;
    }
}
