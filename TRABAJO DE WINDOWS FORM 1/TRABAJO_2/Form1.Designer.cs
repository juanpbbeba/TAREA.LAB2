namespace TRABAJO_2
{
    partial class Form1
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
            lblCodigo = new Label();
            lblNombre = new Label();
            lblCondiciondecontrato = new Label();
            lblEspecialidad = new Label();
            lblTipodeactividad = new Label();
            lblTipodeseguro = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            cboCondicion = new ComboBox();
            cboEspecialidad = new ComboBox();
            cboActividad = new ComboBox();
            cboAfiliado = new ComboBox();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(43, 9);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            lblCodigo.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(259, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label2_Click;
            // 
            // lblCondiciondecontrato
            // 
            lblCondiciondecontrato.AutoSize = true;
            lblCondiciondecontrato.Location = new Point(444, 9);
            lblCondiciondecontrato.Name = "lblCondiciondecontrato";
            lblCondiciondecontrato.Size = new Size(126, 15);
            lblCondiciondecontrato.TabIndex = 2;
            lblCondiciondecontrato.Text = "Condicion de contrato";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(466, 83);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(72, 15);
            lblEspecialidad.TabIndex = 3;
            lblEspecialidad.Text = "Especialidad";
            // 
            // lblTipodeactividad
            // 
            lblTipodeactividad.AutoSize = true;
            lblTipodeactividad.Location = new Point(22, 78);
            lblTipodeactividad.Name = "lblTipodeactividad";
            lblTipodeactividad.Size = new Size(97, 15);
            lblTipodeactividad.TabIndex = 4;
            lblTipodeactividad.Text = "Tipo de actividad";
            // 
            // lblTipodeseguro
            // 
            lblTipodeseguro.AutoSize = true;
            lblTipodeseguro.Location = new Point(235, 83);
            lblTipodeseguro.Name = "lblTipodeseguro";
            lblTipodeseguro.Size = new Size(86, 15);
            lblTipodeseguro.TabIndex = 5;
            lblTipodeseguro.Text = "Tipo de Seguro";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(22, 37);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(235, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // cboCondicion
            // 
            cboCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondicion.FormattingEnabled = true;
            cboCondicion.Items.AddRange(new object[] { "ESTABLE", "CONTRATADO" });
            cboCondicion.Location = new Point(449, 37);
            cboCondicion.Name = "cboCondicion";
            cboCondicion.Size = new Size(121, 23);
            cboCondicion.TabIndex = 8;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "ESTRUCTURAS", "RECURSOS HIDRICOS" });
            cboEspecialidad.Location = new Point(444, 104);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(121, 23);
            cboEspecialidad.TabIndex = 9;
            // 
            // cboActividad
            // 
            cboActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividad.FormattingEnabled = true;
            cboActividad.Items.AddRange(new object[] { "OBRAS", "VÍAS" });
            cboActividad.Location = new Point(22, 104);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(121, 23);
            cboActividad.TabIndex = 10;
            cboActividad.SelectedIndexChanged += cboTipoActividad_SelectedIndexChanged;
            // 
            // cboAfiliado
            // 
            cboAfiliado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAfiliado.FormattingEnabled = true;
            cboAfiliado.Items.AddRange(new object[] { "AFP", "SNP" });
            cboAfiliado.Location = new Point(225, 104);
            cboAfiliado.Name = "cboAfiliado";
            cboAfiliado.Size = new Size(121, 23);
            cboAfiliado.TabIndex = 11;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 133);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(745, 266);
            txtResultado.TabIndex = 12;
            txtResultado.TextChanged += txtBUN_TextChanged;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(50, 411);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 13;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(154, 414);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(490, 414);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(612, 411);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(cboAfiliado);
            Controls.Add(cboActividad);
            Controls.Add(cboEspecialidad);
            Controls.Add(cboCondicion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblTipodeseguro);
            Controls.Add(lblTipodeactividad);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblCondiciondecontrato);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblCondiciondecontrato;
        private Label lblEspecialidad;
        private Label lblTipodeactividad;
        private Label lblTipodeseguro;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private ComboBox cboCondicion;
        private ComboBox cboEspecialidad;
        private ComboBox cboActividad;
        private ComboBox cboAfiliado;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
