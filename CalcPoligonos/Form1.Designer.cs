namespace CalcPoligonos
{
    partial class CalculadoraPoligonosForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalcularAreaButton = new System.Windows.Forms.Button();
            this.CalcularPerimetroButton = new System.Windows.Forms.Button();
            this.principalTabControl = new System.Windows.Forms.TabControl();
            this.trianguloTabPage = new System.Windows.Forms.TabPage();
            this.cuadradoTabPage = new System.Windows.Forms.TabPage();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.CirculoTabPage = new System.Windows.Forms.TabPage();
            this.RectanguloTabPage = new System.Windows.Forms.TabPage();
            this.PentagonoTabPage = new System.Windows.Forms.TabPage();
            this.principalTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcularAreaButton
            // 
            this.CalcularAreaButton.Location = new System.Drawing.Point(676, 399);
            this.CalcularAreaButton.Name = "CalcularAreaButton";
            this.CalcularAreaButton.Size = new System.Drawing.Size(112, 23);
            this.CalcularAreaButton.TabIndex = 0;
            this.CalcularAreaButton.Text = "Calcular Area";
            this.CalcularAreaButton.UseVisualStyleBackColor = true;
            // 
            // CalcularPerimetroButton
            // 
            this.CalcularPerimetroButton.Location = new System.Drawing.Point(554, 399);
            this.CalcularPerimetroButton.Name = "CalcularPerimetroButton";
            this.CalcularPerimetroButton.Size = new System.Drawing.Size(116, 23);
            this.CalcularPerimetroButton.TabIndex = 1;
            this.CalcularPerimetroButton.Text = "Calcular Perimetro";
            this.CalcularPerimetroButton.UseVisualStyleBackColor = true;
            // 
            // principalTabControl
            // 
            this.principalTabControl.Controls.Add(this.trianguloTabPage);
            this.principalTabControl.Controls.Add(this.cuadradoTabPage);
            this.principalTabControl.Controls.Add(this.CirculoTabPage);
            this.principalTabControl.Controls.Add(this.RectanguloTabPage);
            this.principalTabControl.Controls.Add(this.PentagonoTabPage);
            this.principalTabControl.Location = new System.Drawing.Point(12, 59);
            this.principalTabControl.Name = "principalTabControl";
            this.principalTabControl.SelectedIndex = 0;
            this.principalTabControl.ShowToolTips = true;
            this.principalTabControl.Size = new System.Drawing.Size(754, 325);
            this.principalTabControl.TabIndex = 5;
            // 
            // trianguloTabPage
            // 
            this.trianguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.trianguloTabPage.Name = "trianguloTabPage";
            this.trianguloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trianguloTabPage.Size = new System.Drawing.Size(746, 299);
            this.trianguloTabPage.TabIndex = 0;
            this.trianguloTabPage.Text = "Triangulo";
            this.trianguloTabPage.UseVisualStyleBackColor = true;
            // 
            // cuadradoTabPage
            // 
            this.cuadradoTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTabPage.Name = "cuadradoTabPage";
            this.cuadradoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cuadradoTabPage.Size = new System.Drawing.Size(746, 299);
            this.cuadradoTabPage.TabIndex = 1;
            this.cuadradoTabPage.Text = "Cuadrado";
            this.cuadradoTabPage.UseVisualStyleBackColor = true;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(271, 31);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(290, 25);
            this.tituloLabel.TabIndex = 3;
            this.tituloLabel.Text = "Calculradora de Poligonos";
            this.tituloLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CirculoTabPage
            // 
            this.CirculoTabPage.Location = new System.Drawing.Point(4, 22);
            this.CirculoTabPage.Name = "CirculoTabPage";
            this.CirculoTabPage.Size = new System.Drawing.Size(746, 299);
            this.CirculoTabPage.TabIndex = 2;
            this.CirculoTabPage.Text = "Circulo";
            this.CirculoTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanguloTabPage
            // 
            this.RectanguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanguloTabPage.Name = "RectanguloTabPage";
            this.RectanguloTabPage.Size = new System.Drawing.Size(746, 299);
            this.RectanguloTabPage.TabIndex = 3;
            this.RectanguloTabPage.Text = "Rectangulo";
            this.RectanguloTabPage.UseVisualStyleBackColor = true;
            // 
            // PentagonoTabPage
            // 
            this.PentagonoTabPage.Location = new System.Drawing.Point(4, 22);
            this.PentagonoTabPage.Name = "PentagonoTabPage";
            this.PentagonoTabPage.Size = new System.Drawing.Size(746, 299);
            this.PentagonoTabPage.TabIndex = 4;
            this.PentagonoTabPage.Text = "Pentagono";
            this.PentagonoTabPage.UseVisualStyleBackColor = true;
            // 
            // CalculadoraPoligonosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.principalTabControl);
            this.Controls.Add(this.CalcularPerimetroButton);
            this.Controls.Add(this.CalcularAreaButton);
            this.Name = "CalculadoraPoligonosForm";
            this.Text = "Calculadora de Poligonos";
            this.principalTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularAreaButton;
        private System.Windows.Forms.Button CalcularPerimetroButton;
        private System.Windows.Forms.TabControl principalTabControl;
        private System.Windows.Forms.TabPage trianguloTabPage;
        private System.Windows.Forms.TabPage cuadradoTabPage;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TabPage CirculoTabPage;
        private System.Windows.Forms.TabPage RectanguloTabPage;
        private System.Windows.Forms.TabPage PentagonoTabPage;
    }
}

