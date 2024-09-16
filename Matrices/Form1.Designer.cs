namespace OperacionesConMatrices
{
    partial class Form1
    {
        private void InitializeComponent()
{
    this.txtMatriz1 = new System.Windows.Forms.TextBox[2, 2];
    this.txtMatriz2 = new System.Windows.Forms.TextBox[2, 2];
    this.lblSuma = new System.Windows.Forms.Label();
    this.lblResta = new System.Windows.Forms.Label();
    this.lblProducto = new System.Windows.Forms.Label();
    this.lblDivision = new System.Windows.Forms.Label();
    this.btnCalcular = new System.Windows.Forms.Button();

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            this.txtMatriz1[i, j] = new System.Windows.Forms.TextBox();
            this.txtMatriz1[i, j].Location = new System.Drawing.Point(12 + j * 30, 12 + i * 30);
            this.txtMatriz1[i, j].Size = new System.Drawing.Size(25, 20);
            this.Controls.Add(this.txtMatriz1[i, j]);

            this.txtMatriz2[i, j] = new System.Windows.Forms.TextBox();
            this.txtMatriz2[i, j].Location = new System.Drawing.Point(100 + j * 30, 12 + i * 30);
            this.txtMatriz2[i, j].Size = new System.Drawing.Size(25, 20);
            this.Controls.Add(this.txtMatriz2[i, j]);
        }
    }

    // Aumentando el tamaño y la ubicación de las etiquetas para mostrar los resultados
    this.lblSuma.Location = new System.Drawing.Point(12, 80);
    this.lblSuma.AutoSize = false;
    this.lblSuma.Size = new System.Drawing.Size(200, 40); // Aumentar el tamaño para dar espacio a los resultados
    this.lblSuma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

    this.lblResta.Location = new System.Drawing.Point(12, 130);
    this.lblResta.AutoSize = false;
    this.lblResta.Size = new System.Drawing.Size(200, 40); // Aumentar el tamaño para dar espacio a los resultados
    this.lblResta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

    this.lblProducto.Location = new System.Drawing.Point(12, 180);
    this.lblProducto.AutoSize = false;
    this.lblProducto.Size = new System.Drawing.Size(200, 40); // Aumentar el tamaño para dar espacio a los resultados
    this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

    this.lblDivision.Location = new System.Drawing.Point(12, 230);
    this.lblDivision.AutoSize = false;
    this.lblDivision.Size = new System.Drawing.Size(200, 40); // Aumentar el tamaño para dar espacio a los resultados
    this.lblDivision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

    this.Controls.Add(this.lblSuma);
    this.Controls.Add(this.lblResta);
    this.Controls.Add(this.lblProducto);
    this.Controls.Add(this.lblDivision);

    // Botón Calcular
    this.btnCalcular.Location = new System.Drawing.Point(12, 280);
    this.btnCalcular.Text = "Calcular";
    this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

    this.Controls.Add(this.btnCalcular);

    // Propiedades del Formulario
    this.ClientSize = new System.Drawing.Size(250, 350); // Ajusta el tamaño total del formulario
    this.Name = "Form1";
    this.Text = "Operaciones con Matrices";
}
    }
}
