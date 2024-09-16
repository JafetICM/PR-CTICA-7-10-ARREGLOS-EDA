namespace MatrizDiagonal
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();

            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(12, 12);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 20);
            this.txtTamaño.TabIndex = 0;
            this.txtTamaño.PlaceholderText = "Tamaño de la matriz";

            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(120, 10);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(12, 40);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(260, 200);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblResultado.Font = new System.Drawing.Font("Courier New", 10);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Matriz Diagonal";
        }
    }
}
