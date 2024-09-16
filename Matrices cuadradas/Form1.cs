using System;
using System.Windows.Forms;

namespace MatrizDiagonal
{
    public partial class Form1 : Form
    {
        private TextBox txtTamaño;
        private Button btnGenerar;
        private Label lblResultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtTamaño.Text, out n) && n > 0)
            {
                int[,] matriz = new int[n, n];
                
                // Llenar la matriz según las condiciones indicadas
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matriz[i, j] = (i == j) ? 1 : 0;
                    }
                }

                // Mostrar la matriz resultante
                string resultado = "Matriz resultante:\n";
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        resultado += matriz[i, j] + " ";
                    }
                    resultado += "\n";
                }

                lblResultado.Text = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
