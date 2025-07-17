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
            bntCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
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
            tabControlVentas.Location = new Point(-1, 72);
            tabControlVentas.Name = "tabControlVentas";
            tabControlVentas.SelectedIndex = 0;
            tabControlVentas.Size = new Size(602, 265);
            tabControlVentas.TabIndex = 3;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btn_modificar);
            tabPageLista.Controls.Add(bntAgregar);
            tabPageLista.Controls.Add(dataGridVentas);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(594, 237);
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
            btnEliminar.Location = new Point(455, 156);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 47);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            btn_modificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btn_modificar.IconColor = Color.Black;
            btn_modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_modificar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_modificar.Location = new Point(455, 92);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(105, 47);
            btn_modificar.TabIndex = 5;
            btn_modificar.Text = "Modificar ";
            btn_modificar.TextAlign = ContentAlignment.MiddleRight;
            btn_modificar.UseVisualStyleBackColor = true;
            // 
            // bntAgregar
            // 
            bntAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            bntAgregar.IconColor = Color.Black;
            bntAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            bntAgregar.Location = new Point(455, 28);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(105, 47);
            bntAgregar.TabIndex = 4;
            bntAgregar.Text = "Agregar";
            bntAgregar.TextAlign = ContentAlignment.MiddleRight;
            bntAgregar.UseVisualStyleBackColor = true;

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
            dataGridVentas.Size = new Size(406, 241);
            dataGridVentas.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(bntCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(label2);
            tabPageAgregarEditar.Location = new Point(4, 24);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(3);
            tabPageAgregarEditar.Size = new Size(594, 237);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // bntCancelar
            // 
            bntCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            bntCancelar.IconColor = Color.Black;
            bntCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            bntCancelar.Location = new Point(344, 125);
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
            btnGuardar.Location = new Point(144, 125);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 53);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;

            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(198, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 23);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 29);
            label1.TabIndex = 4;
            label1.Text = "Ventas";
            // 
            // VentaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 336);
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
        private TextBox txtNombre;
        private Label label2;
        public Label label1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btn_modificar;
        private FontAwesome.Sharp.IconButton bntAgregar;
    }
}