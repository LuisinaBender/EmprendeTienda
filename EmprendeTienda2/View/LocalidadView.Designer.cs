namespace EmprendeTiendaDesktop.View
{
    partial class LocalidadView
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
            tabControlLocalidad = new TabControl();
            tabPageLista = new TabPage();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btn_modificar = new FontAwesome.Sharp.IconButton();
            bntAgregar = new FontAwesome.Sharp.IconButton();
            dataGridLocalidades = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            bntCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            label2 = new Label();
            tabControlLocalidad.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 29);
            label1.TabIndex = 0;
            label1.Text = "Localidades";
            // 
            // tabControlLocalidad
            // 
            tabControlLocalidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlLocalidad.Controls.Add(tabPageLista);
            tabControlLocalidad.Controls.Add(tabPageAgregarEditar);
            tabControlLocalidad.Location = new Point(0, 67);
            tabControlLocalidad.Name = "tabControlLocalidad";
            tabControlLocalidad.SelectedIndex = 0;
            tabControlLocalidad.Size = new Size(564, 282);
            tabControlLocalidad.TabIndex = 1;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btn_modificar);
            tabPageLista.Controls.Add(bntAgregar);
            tabPageLista.Controls.Add(dataGridLocalidades);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(556, 254);
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
            btnEliminar.Location = new Point(391, 152);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 47);
            btnEliminar.TabIndex = 3;
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
            btn_modificar.Location = new Point(391, 88);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(105, 47);
            btn_modificar.TabIndex = 2;
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
            bntAgregar.Location = new Point(391, 24);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(105, 47);
            bntAgregar.TabIndex = 1;
            bntAgregar.Text = "Agregar";
            bntAgregar.TextAlign = ContentAlignment.MiddleRight;
            bntAgregar.UseVisualStyleBackColor = true;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // dataGridLocalidades
            // 
            dataGridLocalidades.AllowUserToAddRows = false;
            dataGridLocalidades.AllowUserToDeleteRows = false;
            dataGridLocalidades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLocalidades.Location = new Point(3, 6);
            dataGridLocalidades.Name = "dataGridLocalidades";
            dataGridLocalidades.ReadOnly = true;
            dataGridLocalidades.Size = new Size(281, 245);
            dataGridLocalidades.TabIndex = 0;
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
            tabPageAgregarEditar.Size = new Size(556, 254);
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
            bntCancelar.Location = new Point(284, 125);
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
            btnGuardar.Location = new Point(100, 125);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 53);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
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
            label2.Location = new Point(134, 64);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // LocalidadView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 349);
            Controls.Add(tabControlLocalidad);
            Controls.Add(label1);
            Name = "LocalidadView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Localidades";
            tabControlLocalidad.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControlLocalidad;
        private TabPage tabPageLista;
        private DataGridView dataGridLocalidades;
        private TabPage tabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton bntCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private FontAwesome.Sharp.IconButton bntAgregar;
        private FontAwesome.Sharp.IconButton btn_modificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}