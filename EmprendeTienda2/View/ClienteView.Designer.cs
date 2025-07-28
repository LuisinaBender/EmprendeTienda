namespace EmprendeTiendaDesktop.View
{
    partial class ClienteView
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
            tabControlClientes = new TabControl();
            tabPageLista = new TabPage();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btn_modificar = new FontAwesome.Sharp.IconButton();
            bntAgregar = new FontAwesome.Sharp.IconButton();
            dataGridClientes = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            comboLocalidades = new ComboBox();
            label7 = new Label();
            txtDireccion = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            bntCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            tabControlClientes.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 28);
            label1.Name = "label1";
            label1.Size = new Size(92, 29);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // tabControlClientes
            // 
            tabControlClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlClientes.Controls.Add(tabPageLista);
            tabControlClientes.Controls.Add(tabPageAgregarEditar);
            tabControlClientes.Location = new Point(0, 60);
            tabControlClientes.Name = "tabControlClientes";
            tabControlClientes.SelectedIndex = 0;
            tabControlClientes.Size = new Size(732, 337);
            tabControlClientes.TabIndex = 2;
            // 
            // tabPageLista
            // 
            tabPageLista.BackColor = Color.FromArgb(200, 133, 226);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btn_modificar);
            tabPageLista.Controls.Add(bntAgregar);
            tabPageLista.Controls.Add(dataGridClientes);
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
            btnEliminar.Location = new Point(592, 197);
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
            btn_modificar.Location = new Point(592, 133);
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
            bntAgregar.Location = new Point(593, 69);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(104, 47);
            bntAgregar.TabIndex = 4;
            bntAgregar.Text = "Agregar";
            bntAgregar.TextAlign = ContentAlignment.MiddleRight;
            bntAgregar.UseVisualStyleBackColor = false;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // dataGridClientes
            // 
            dataGridClientes.AllowUserToAddRows = false;
            dataGridClientes.AllowUserToDeleteRows = false;
            dataGridClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Location = new Point(0, 0);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.Size = new Size(577, 313);
            dataGridClientes.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.BackColor = Color.FromArgb(200, 133, 226);
            tabPageAgregarEditar.Controls.Add(comboLocalidades);
            tabPageAgregarEditar.Controls.Add(label7);
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(txtTelefono);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(txtEmail);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(txtApellido);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Controls.Add(bntCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(724, 309);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            // 
            // comboLocalidades
            // 
            comboLocalidades.FormattingEnabled = true;
            comboLocalidades.Location = new Point(181, 215);
            comboLocalidades.Name = "comboLocalidades";
            comboLocalidades.Size = new Size(245, 23);
            comboLocalidades.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 219);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 16;
            label7.Text = "Localidad";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(181, 182);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(245, 23);
            txtDireccion.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 190);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 14;
            label6.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(181, 153);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(245, 23);
            txtTelefono.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 161);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 12;
            label5.Text = "Telefono";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(181, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 23);
            txtEmail.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 132);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Email:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(181, 95);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(245, 23);
            txtApellido.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 103);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 8;
            label3.Text = "Apellido:";
            // 
            // bntCancelar
            // 
            bntCancelar.BackColor = Color.FromArgb(151, 46, 194);
            bntCancelar.ForeColor = SystemColors.ControlLightLight;
            bntCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            bntCancelar.IconColor = Color.White;
            bntCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntCancelar.IconSize = 28;
            bntCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            bntCancelar.Location = new Point(475, 171);
            bntCancelar.Name = "bntCancelar";
            bntCancelar.Size = new Size(84, 53);
            bntCancelar.TabIndex = 7;
            bntCancelar.Text = " Cancelar";
            bntCancelar.TextAlign = ContentAlignment.MiddleRight;
            bntCancelar.UseVisualStyleBackColor = false;
            bntCancelar.Click += bntCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(151, 46, 194);
            btnGuardar.ForeColor = SystemColors.ControlLight;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 30;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(475, 74);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(84, 53);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 23);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 182, 238);
            ClientSize = new Size(723, 395);
            Controls.Add(tabControlClientes);
            Controls.Add(label1);
            Name = "ClienteView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClienteView";
            tabControlClientes.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        private TabControl tabControlClientes;
        private TabPage tabPageLista;
        private DataGridView dataGridClientes;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton bntCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btn_modificar;
        private FontAwesome.Sharp.IconButton bntAgregar;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtApellido;
        private Label label3;
        private Label label7;
        private TextBox txtDireccion;
        private Label label6;
        private ComboBox comboLocalidades;
    }
}