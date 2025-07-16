namespace EmprendeTiendaDescktop.View
{
    partial class ProductosViews
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabControlProductos = new TabControl();
            tabPageLista = new TabPage();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btn_modificar = new FontAwesome.Sharp.IconButton();
            bntAgregar = new FontAwesome.Sharp.IconButton();
            dataGridProductos = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            txtStock = new TextBox();
            label5 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            bntCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            tabControlProductos.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 31);
            label1.Name = "label1";
            label1.Size = new Size(112, 29);
            label1.TabIndex = 3;
            label1.Text = "Productos";
            // 
            // tabControlProductos
            // 
            tabControlProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlProductos.Controls.Add(tabPageLista);
            tabControlProductos.Controls.Add(tabPageAgregarEditar);
            tabControlProductos.Location = new Point(12, 63);
            tabControlProductos.Name = "tabControlProductos";
            tabControlProductos.SelectedIndex = 0;
            tabControlProductos.Size = new Size(676, 307);
            tabControlProductos.TabIndex = 4;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btn_modificar);
            tabPageLista.Controls.Add(bntAgregar);
            tabPageLista.Controls.Add(dataGridProductos);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(668, 279);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(553, 173);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 47);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btn_modificar.IconColor = Color.Black;
            btn_modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_modificar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_modificar.Location = new Point(553, 109);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(105, 47);
            btn_modificar.TabIndex = 5;
            btn_modificar.Text = "Modificar ";
            btn_modificar.TextAlign = ContentAlignment.MiddleRight;
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // bntAgregar
            // 
            bntAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            bntAgregar.IconColor = Color.Black;
            bntAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            bntAgregar.Location = new Point(553, 45);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(105, 47);
            bntAgregar.TabIndex = 4;
            bntAgregar.Text = "Agregar";
            bntAgregar.TextAlign = ContentAlignment.MiddleRight;
            bntAgregar.UseVisualStyleBackColor = true;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToAddRows = false;
            dataGridProductos.AllowUserToDeleteRows = false;
            dataGridProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Location = new Point(0, 1);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.Size = new Size(547, 275);
            dataGridProductos.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(txtStock);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(txtPrecio);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(txtDescripcion);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Controls.Add(bntCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(668, 279);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(159, 162);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(245, 23);
            txtStock.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 165);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 12;
            label5.Text = "Stock:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(159, 133);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(245, 23);
            txtPrecio.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 141);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 10;
            label4.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(159, 104);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(245, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 112);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 8;
            label3.Text = "Descripcion:";
            // 
            // bntCancelar
            // 
            bntCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            bntCancelar.IconColor = Color.Black;
            bntCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            bntCancelar.Location = new Point(427, 153);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(138, 53);
            bntCancelar.TabIndex = 7;
            bntCancelar.Text = "Cancelar";
            bntCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(427, 56);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 53);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(159, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 23);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 86);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // ProductosViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 375);
            Controls.Add(tabControlProductos);
            Controls.Add(label1);
            Name = "ProductosViews";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Productos";
            tabControlProductos.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label label1;
        private TabControl tabControlProductos;
        private TabPage tabPageLista;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btn_modificar;
        private FontAwesome.Sharp.IconButton bntAgregar;
        private DataGridView dataGridProductos;
        private TabPage tabPageAgregarEditar;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label3;
        private FontAwesome.Sharp.IconButton bntCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
    }
}