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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_productos
            // 
            btn_productos.BackColor = Color.RosyBrown;
            btn_productos.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btn_productos.IconColor = Color.AntiqueWhite;
            btn_productos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_productos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_productos.Location = new Point(109, 112);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(134, 66);
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
            btn_clientes.Location = new Point(109, 219);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(134, 66);
            btn_clientes.TabIndex = 4;
            btn_clientes.Text = "Clientes";
            btn_clientes.TextAlign = ContentAlignment.MiddleRight;
            btn_clientes.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.MistyRose;
            iconPictureBox1.ForeColor = Color.IndianRed;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconPictureBox1.IconColor = Color.IndianRed;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 73;
            iconPictureBox1.Location = new Point(144, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(76, 73);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(348, 367);
            Controls.Add(iconPictureBox1);
            Controls.Add(btn_clientes);
            Controls.Add(btn_productos);
            Margin = new Padding(4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emprende Tienda";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_productos;
        private FontAwesome.Sharp.IconButton btn_clientes;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
