namespace WinFormstrabajo2
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
            lblNombre = new Label();
            lblDni = new Label();
            lblCargo = new Label();
            lblAntiguedad = new Label();
            lblArea = new Label();
            txtNombres = new TextBox();
            txtDni = new TextBox();
            txtAntigüedad = new TextBox();
            cboCargo = new ComboBox();
            cboArea = new ComboBox();
            txtResultado = new TextBox();
            button1 = new Button();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(48, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(180, 49);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(302, 49);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo";
            // 
            // lblAntiguedad
            // 
            lblAntiguedad.AutoSize = true;
            lblAntiguedad.Location = new Point(424, 49);
            lblAntiguedad.Name = "lblAntiguedad";
            lblAntiguedad.Size = new Size(69, 15);
            lblAntiguedad.TabIndex = 3;
            lblAntiguedad.Text = "Antiguedad";
            lblAntiguedad.Click += label1_Click_1;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(555, 49);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(31, 15);
            lblArea.TabIndex = 4;
            lblArea.Text = "Area";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(29, 76);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(100, 23);
            txtNombres.TabIndex = 5;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(146, 76);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 6;
            // 
            // txtAntigüedad
            // 
            txtAntigüedad.Location = new Point(412, 76);
            txtAntigüedad.Name = "txtAntigüedad";
            txtAntigüedad.Size = new Size(100, 23);
            txtAntigüedad.TabIndex = 7;
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "GERENTE", "SUBGERENTE" });
            cboCargo.Location = new Point(263, 76);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(121, 23);
            cboCargo.TabIndex = 8;
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "CONTABILIDAD", "PLANIFICACIÓN" });
            cboArea.Location = new Point(534, 76);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(121, 23);
            cboArea.TabIndex = 9;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 105);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(760, 300);
            txtResultado.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(19, 412);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 12;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(132, 412);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 13;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(424, 411);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(555, 411);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button2_Click;
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
            Controls.Add(button1);
            Controls.Add(txtResultado);
            Controls.Add(cboArea);
            Controls.Add(cboCargo);
            Controls.Add(txtAntigüedad);
            Controls.Add(txtDni);
            Controls.Add(txtNombres);
            Controls.Add(lblArea);
            Controls.Add(lblAntiguedad);
            Controls.Add(lblCargo);
            Controls.Add(lblDni);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDni;
        private Label lblCargo;
        private Label lblAntiguedad;
        private Label lblArea;
        private TextBox txtNombres;
        private TextBox txtDni;
        private TextBox txtAntigüedad;
        private ComboBox cboCargo;
        private ComboBox cboArea;
        private TextBox txtResultado;
        private Button button1;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
