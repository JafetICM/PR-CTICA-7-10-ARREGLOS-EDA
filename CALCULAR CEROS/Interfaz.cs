using System;
using System.Windows.Forms;

namespace Contar_ceros
{
    public partial class Interfaz : Form
    {
        // Inicialización de los controles
        private System.Windows.Forms.TextBox txtMatriz = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.Label lblResultado = new System.Windows.Forms.Label();
        private System.Windows.Forms.Button btnCalcular = new System.Windows.Forms.Button();

        public Interfaz()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Definir la matriz (esto puede modificarse para permitir la entrada del usuario)
                int[,] matriz = {
                    { 0, 2, 5, 7, 6 },
                    { 0, 0, 0, 3, 8 },
                    { 2, 9, 6, 3, 4 },
                    { 1, 5, 6, 1, 4 },
                    { 0, 9, 2, 5, 0 }
                };

                // Instanciar la clase ContadorDeCeros y obtener el resultado
                ContadorDeCeros contador = new ContadorDeCeros();
                string resultado = contador.Contar_ceros(matriz);

                // Mostrar el resultado en el Label
                lblResultado.Text = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
