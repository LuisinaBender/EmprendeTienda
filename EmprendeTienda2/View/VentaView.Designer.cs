namespace EmprendeTiendaDesktop.View
{
    partial class VentaView
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
            tabControlVentas = new TabControl();
            tabPageLista = new TabPage();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btn_modificar = new FontAwesome.Sharp.IconButton();
            bntAgregar = new FontAwesome.Sharp.IconButton();
            dataGridVentas = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            labelPrecio = new Label();
            txtPrecio = new TextBox();
            labelCantidad = new Label();
            txtCantidad = new TextBox();
            labelFecha = new Label();
            dateTimeFecha = new DateTimePicker();
            labelProductos = new Label();
            comboCliente = new ComboBox();
            comboProductos = new ComboBox();
            bntCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            labelNombre = new Label();
            label1 = new Label();
            tabControlVentas.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlVentas
            // 
            tabControlVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlVentas.Controls.Add(tabPageLista);
            tabControlVentas.Controls.Add(tabPageAgregarEditar);
            tabControlVentas.Location = new Point(0, 62);
            tabControlVentas.Name = "tabControlVentas";
            tabControlVentas.SelectedIndex = 0;
            tabControlVentas.Size = new Size(732, 337);
            tabControlVentas.TabIndex = 3;
            // 
            // tabPageLista
            // 
            tabPageLista.BackColor = Color.FromArgb(200, 133, 226);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btn_modificar);
            tabPageLista.Controls.Add(bntAgregar);
            tabPageLista.Controls.Add(dataGridVentas);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(724, 309);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(151, 46, 194);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 30;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(594, 198);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 47);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Anchor = AnchorStyles.Right;
            btn_modificar.BackColor = Color.FromArgb(151, 46, 194);
            btn_modificar.ForeColor = SystemColors.ControlLightLight;
            btn_modificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btn_modificar.IconColor = Color.White;
            btn_modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_modificar.IconSize = 30;
            btn_modificar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_modificar.Location = new Point(594, 134);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(105, 47);
            btn_modificar.TabIndex = 5;
            btn_modificar.Text = "Modificar ";
            btn_modificar.TextAlign = ContentAlignment.MiddleRight;
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // bntAgregar
            // 
            bntAgregar.Anchor = AnchorStyles.Right;
            bntAgregar.BackColor = Color.FromArgb(151, 46, 194);
            bntAgregar.ForeColor = SystemColors.ControlLightLight;
            bntAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            bntAgregar.IconColor = Color.White;
            bntAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntAgregar.IconSize = 30;
            bntAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            bntAgregar.Location = new Point(594, 70);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(105, 47);
            bntAgregar.TabIndex = 4;
            bntAgregar.Text = "Agregar";
            bntAgregar.TextAlign = ContentAlignment.MiddleRight;
            bntAgregar.UseVisualStyleBackColor = false;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // dataGridVentas
            // 
            dataGridVentas.AllowUserToAddRows = false;
            dataGridVentas.AllowUserToDeleteRows = false;
            dataGridVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVentas.Location = new Point(2, 0);
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.ReadOnly = true;
            dataGridVentas.Size = new Size(568, 320);
            dataGridVentas.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.BackColor = Color.FromArgb(200, 133, 226);
            tabPageAgregarEditar.Controls.Add(labelPrecio);
            tabPageAgregarEditar.Controls.Add(txtPrecio);
            tabPageAgregarEditar.Controls.Add(labelCantidad);
            tabPageAgregarEditar.Controls.Add(txtCantidad);
            tabPageAgregarEditar.Controls.Add(labelFecha);
            tabPageAgregarEditar.Controls.Add(dateTimeFecha);
            tabPageAgregarEditar.Controls.Add(labelProductos);
            tabPageAgregarEditar.Controls.Add(comboCliente);
            tabPageAgregarEditar.Controls.Add(comboProductos);
            tabPageAgregarEditar.Controls.Add(bntCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(labelNombre);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(724, 309);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(155, 206);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(43, 15);
            labelPrecio.TabIndex = 26;
            labelPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(204, 203);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(245, 23);
            txtPrecio.TabIndex = 25;
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Location = new Point(143, 175);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(58, 15);
            labelCantidad.TabIndex = 24;
            labelCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(204, 172);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(245, 23);
            txtCantidad.TabIndex = 23;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(94, 149);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(104, 15);
            labelFecha.TabIndex = 22;
            labelFecha.Text = "Seleccionar Fecha:";
            // 
            // dateTimeFecha
            // 
            dateTimeFecha.Location = new Point(204, 143);
            dateTimeFecha.Name = "dateTimeFecha";
            dateTimeFecha.Size = new Size(245, 23);
            dateTimeFecha.TabIndex = 21;
            // 
            // labelProductos
            // 
            labelProductos.AutoSize = true;
            labelProductos.Location = new Point(67, 122);
            labelProductos.Name = "labelProductos";
            labelProductos.Size = new Size(134, 15);
            labelProductos.TabIndex = 20;
            labelProductos.Text = "Seleccionar el Producto:";
            // 
            // comboCliente
            // 
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(204, 85);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(245, 23);
            comboCliente.TabIndex = 19;
            // 
            // comboProductos
            // 
            comboProductos.FormattingEnabled = true;
            comboProductos.Location = new Point(204, 114);
            comboProductos.Name = "comboProductos";
            comboProductos.Size = new Size(245, 23);
            comboProductos.TabIndex = 18;
            // 
            // bntCancelar
            // 
            bntCancelar.BackColor = Color.FromArgb(151, 46, 194);
            bntCancelar.ForeColor = SystemColors.ControlLightLight;
            bntCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            bntCancelar.IconColor = Color.White;
            bntCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntCancelar.IconSize = 30;
            bntCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            bntCancelar.Location = new Point(491, 173);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(86, 53);
            bntCancelar.TabIndex = 7;
            bntCancelar.Text = "Cancelar";
            bntCancelar.TextAlign = ContentAlignment.MiddleRight;
            bntCancelar.UseVisualStyleBackColor = false;
            bntCancelar.Click += bntCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(151, 46, 194);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 30;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(491, 85);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 53);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(88, 93);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(113, 15);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre del Cliente:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 30);
            label1.Name = "label1";
            label1.Size = new Size(80, 29);
            label1.TabIndex = 4;
            label1.Text = "Ventas";
            // 
            // VentaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 182, 238);
            ClientSize = new Size(725, 393);
            Controls.Add(label1);
            Controls.Add(tabControlVentas);
            Name = "VentaView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VentaView";
            tabControlVentas.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlVentas;
        private TabPage tabPageLista;
        private DataGridView dataGridVentas;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton bntCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label labelNombre;
        public Label label1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btn_modificar;
        private FontAwesome.Sharp.IconButton bntAgregar;
        private ComboBox comboCliente;
        private ComboBox comboProductos;
        private DateTimePicker dateTimeFecha;
        private Label labelProductos;
        private Label labelPrecio;
        private TextBox txtPrecio;
        private Label labelCantidad;
        private TextBox txtCantidad;
        private Label labelFecha;
    }
}