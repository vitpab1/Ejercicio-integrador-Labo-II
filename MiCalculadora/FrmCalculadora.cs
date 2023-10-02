using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {

        private Numeracion.ESistema sistema;
        private Operacion? calcular;
        private Numeracion? primerOperando;
        private Numeracion? segundoOperando;
        private Numeracion? mostrarResultado;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperacion.SelectedIndex = 0;
            lblResultado.Text = "";
            rdbDecimal.Checked = true;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Clear();
            txtSegundoOperador.Clear();
            lblResultado.Text = "";
            cmbOperacion.SelectedIndex = 0;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string primerOperando = txtPrimerOperador.Text;
            string segundoOperando = txtSegundoOperador.Text;

            if (string.IsNullOrWhiteSpace(primerOperando) || string.IsNullOrWhiteSpace(segundoOperando))
            {
                MessageBox.Show("Completar ambos campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.primerOperando = new Numeracion(primerOperando, sistema);
            this.segundoOperando = new Numeracion(segundoOperando, sistema);

            calcular = new Operacion(this.primerOperando, this.segundoOperando);
            mostrarResultado = calcular.Operar(cmbOperacion.Text[0]);

            SetResultado();
        }


        private void SetResultado()
        {
            if (mostrarResultado is not null)
            {
                lblResultado.Text =  mostrarResultado.ConvertirA(sistema);
            }
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            primerOperando = new Numeracion(txtPrimerOperador.Text, Numeracion.ESistema.Decimal);
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            segundoOperando = new Numeracion(txtSegundoOperador.Text, Numeracion.ESistema.Decimal);
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                sistema = Numeracion.ESistema.Binario;
                SetResultado();
            }
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDecimal.Checked)
            {
                sistema = Numeracion.ESistema.Decimal;
                SetResultado();
            }
        }



        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}