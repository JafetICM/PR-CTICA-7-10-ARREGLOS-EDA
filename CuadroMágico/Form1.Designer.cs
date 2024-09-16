namespace CuadradoMagico
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();

            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(12, 12);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(100, 20);
            this.txtDimension.TabIndex = 0;
            this.txtDimension.Text = "3"; // Tamaño predeterminado

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 60);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 1;

            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(12, 38);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtDimension);
            this.Name = "Form1";
            this.Text = "Cuadrado Mágico";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
