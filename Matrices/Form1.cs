using System;
using System.Windows.Forms;

namespace OperacionesConMatrices
{
    public partial class Form1 : Form
    {
        private TextBox[,] txtMatriz1;
        private TextBox[,] txtMatriz2;
        private Label lblSuma;
        private Label lblResta;
        private Label lblProducto;
        private Label lblDivision;
        private Button btnCalcular;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matriz1 = new int[2, 2];
                int[,] matriz2 = new int[2, 2];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        matriz1[i, j] = int.Parse(txtMatriz1[i, j].Text);
                        matriz2[i, j] = int.Parse(txtMatriz2[i, j].Text);
                    }
                }

                Matrices operaciones = new Matrices();

                int[,] suma = operaciones.SumarMatrices(matriz1, matriz2);
                int[,] resta = operaciones.RestarMatrices(matriz1, matriz2);
                int[,] producto = operaciones.MultiplicarMatrices(matriz1, matriz2);
                double[,] division = operaciones.DividirMatrices(matriz1, matriz2);

                lblSuma.Text = $"La suma es:\n{suma[0, 0]}  {suma[0, 1]}\n{suma[1, 0]}  {suma[1, 1]}";
                lblResta.Text = $"La resta es:\n{resta[0, 0]}  {resta[0, 1]}\n{resta[1, 0]}  {resta[1, 1]}";
                lblProducto.Text = $"El producto es:\n{producto[0, 0]}  {producto[0, 1]}\n{producto[1, 0]}  {producto[1, 1]}";
                lblDivision.Text = $"La división es:\n{division[0, 0]:0.##}  {division[0, 1]:0.##}\n{division[1, 0]:0.##}  {division[1, 1]:0.##}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, ingrese solo números enteros en las matrices.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero. Por favor, asegúrese de que todas las entradas en la segunda matriz sean diferentes de cero para la división.", "Error de división", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
