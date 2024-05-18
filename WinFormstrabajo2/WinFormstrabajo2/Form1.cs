namespace WinFormstrabajo2
{
    public partial class Form1 : Form
    {
        Jefe jefe;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            string dni = txtDni.Text;
            string cargo = cboCargo.Text;
            string area = cboArea.Text;
            int antiguedad = int.Parse(txtAntigüedad.Text);

            jefe = new Jefe(nombre, dni, cargo, area, antiguedad);
            MessageBox.Show("OBJETO CREADO");

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            double sueldoBase = jefe.CalcularSueldoBase();
            double bonificacion = jefe.CalcularBonificacion();


            txtResultado.AppendText("DNI: " + jefe.Dni + Environment.NewLine);
            txtResultado.AppendText("Nombre: " + jefe.Nombres + Environment.NewLine);
            txtResultado.AppendText("Cargo: " + jefe.Cargo + Environment.NewLine);
            txtResultado.AppendText("Area: " + jefe.Area + Environment.NewLine);
            txtResultado.AppendText("Años de Antiguedad: " + jefe.AnosAntiguedad + Environment.NewLine);
            txtResultado.AppendText("Sueldo Base: " + sueldoBase + Environment.NewLine);
            txtResultado.AppendText("Bonificacion: " + bonificacion + Environment.NewLine);
            txtResultado.AppendText("Movilidad : " + jefe.AsignarMontoMovilidad() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Final: " + jefe.CalcularSueldoFinal() + Environment.NewLine);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDni.Clear();
            txtNombres.Clear();
            txtAntigüedad.Clear();
            txtResultado.Clear();

            cboArea.SelectedIndex = -1;
            cboCargo.SelectedIndex = -1;

        }
    }
}
