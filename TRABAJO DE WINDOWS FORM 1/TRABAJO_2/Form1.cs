namespace TRABAJO_2
{
    public partial class Form1 : Form
    {
        Arquitecto arquitecto;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBUN_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombres = txtNombre.Text;
            string condicionContrato = cboCondicion.Text.Trim().ToLower();
            string especialidad = cboEspecialidad.Text.Trim().ToLower();
            string tipoactividad = cboActividad.Text.Trim().ToLower();
            string tipoafiliado = cboAfiliado.Text.Trim().ToLower();

            arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoactividad, tipoafiliado);
            MessageBox.Show("OBJETO CREADO");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombres = txtNombre.Text;
            string condicionContrato = cboCondicion.Text.Trim().ToLower();
            string especialidad = cboEspecialidad.Text.Trim().ToLower();
            string tipoactividad = cboActividad.Text.Trim().ToLower();
            string tipoafiliado = cboAfiliado.Text.Trim().ToLower();

            arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoactividad, tipoafiliado);
            MessageBox.Show("OBJETO CREADO");
        }

        private void cboTipoActividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.AppendText("Codigo: " + arquitecto.Codigo + Environment.NewLine);
            txtResultado.AppendText("Nombres: " + arquitecto.Nombre + Environment.NewLine);
            txtResultado.AppendText("Condicion de contrato : " + arquitecto.CondicionContrato + Environment.NewLine);
            txtResultado.AppendText("Especialidad: " + arquitecto.Especialidad + Environment.NewLine);
            txtResultado.AppendText("Tipo de Actividad: " + arquitecto.TipoActividad + Environment.NewLine);
            txtResultado.AppendText("Tipo de Afiliacion: " + arquitecto.TipoAfiliado + Environment.NewLine);
            txtResultado.AppendText("Sueldo Base: " + arquitecto.CalcularSueldoBase() + Environment.NewLine);
            txtResultado.AppendText("Bonificacion: " + arquitecto.CalcularBonificacion() + Environment.NewLine);
            txtResultado.AppendText("Monto de Descuento: " + arquitecto.CalcularDescuento() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Bruto: " + arquitecto.CalcularSueldoBruto() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Neto: " + arquitecto.CalcularSueldoNeto() + Environment.NewLine);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtResultado.Clear();

            cboCondicion.SelectedIndex = -1;
            cboEspecialidad.SelectedIndex = -1;
            cboActividad.SelectedIndex = -1;
            cboAfiliado.SelectedIndex = -1;
        }
    }
}
