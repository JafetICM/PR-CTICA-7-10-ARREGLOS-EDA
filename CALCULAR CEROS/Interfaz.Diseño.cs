namespace Contar_ceros
{
    partial class Interfaz
    {
        private void InitializeComponent()
        {
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
    
            // 
            // txtMatriz
            // 
            this.txtMatriz.Location = new System.Drawing.Point(12, 12);
            this.txtMatriz.Multiline = true;
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(260, 100);
            this.txtMatriz.TabIndex = 0;
            this.txtMatriz.Text = "0 2 5 7 6\n0 0 0 3 8\n2 9 6 3 4\n1 5 6 1 4\n0 9 2 5 0"; // Matriz predefinida

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 1;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtMatriz);
            this.Name = "Form1";
            this.Text = "Contar Ceros en Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
