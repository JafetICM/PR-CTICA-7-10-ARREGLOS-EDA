using System;
using System.Windows.Forms;

namespace CuadradoMagico
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TextBox txtDimension = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.Label lblResultado = new System.Windows.Forms.Label();
        private System.Windows.Forms.Button btnGenerar = new System.Windows.Forms.Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtDimension.Text);
                CuadradoMagico cuadradoMagico = new CuadradoMagico();

                int[,] cuadrado = cuadradoMagico.GenerarCuadradoMagico(n);
                string resultado = MostrarCuadrado(cuadrado);

                if (cuadradoMagico.EsCuadradoMagico(cuadrado))
                {
                    resultado += "\nEl cuadrado es un cuadrado mágico.";
                }
                else
                {
                    resultado += "\nEl cuadrado NO es un cuadrado mágico.";
                }

                lblResultado.Text = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string MostrarCuadrado(int[,] cuadrado)
        {
            int n = cuadrado.GetLength(0);
            string resultado = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultado += cuadrado[i, j] + "\t";
                }
                resultado += "\n";
            }

            return resultado;
        }
    }
}
