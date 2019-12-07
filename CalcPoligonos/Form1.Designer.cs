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
            this.CirculoTabPage = new System.Windows.Forms.TabPage();
            this.RectanguloTabPage = new System.Windows.Forms.TabPage();
            this.PentagonoTabPage = new System.Windows.Forms.TabPage();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.trianguloBaseLabel = new System.Windows.Forms.Label();
            this.trianguloBaseTextBox = new System.Windows.Forms.TextBox();
            this.trianguloAlturaTextBox = new System.Windows.Forms.TextBox();
            this.trianguloAlturaLabel = new System.Windows.Forms.Label();
            this.trianguloLado3Label = new System.Windows.Forms.Label();
            this.trianguloLado3TextBox = new System.Windows.Forms.TextBox();
            this.trianguloLado2Label = new System.Windows.Forms.Label();
            this.trianguloLado2TextBox = new System.Windows.Forms.TextBox();
            this.trianguloLado1TextBox = new System.Windows.Forms.TextBox();
            this.trianguloLado1Label = new System.Windows.Forms.Label();
            this.CuadradoLadoLabel = new System.Windows.Forms.Label();
            this.CuadradoLadoTextBox = new System.Windows.Forms.TextBox();
            this.circuloPerimetroTextBox = new System.Windows.Forms.TextBox();
            this.circuloDiametroLabel = new System.Windows.Forms.Label();
            this.circuloRadioTextBox = new System.Windows.Forms.TextBox();
            this.circuloRadioLabel = new System.Windows.Forms.Label();
            this.rectanguloBaseTextBox = new System.Windows.Forms.TextBox();
            this.rectanguloBaseLabel = new System.Windows.Forms.Label();
            this.rectanguloAlturaTextBox = new System.Windows.Forms.TextBox();
            this.rectanguloAlturaLabel = new System.Windows.Forms.Label();
            this.pentagonoLadoTextBox = new System.Windows.Forms.TextBox();
            this.pentagonLadoLabel = new System.Windows.Forms.Label();
            this.pentagonoApotemaTextBox = new System.Windows.Forms.TextBox();
            this.pentagonoApotemaLabel = new System.Windows.Forms.Label();
            this.principalTabControl.SuspendLayout();
            this.trianguloTabPage.SuspendLayout();
            this.cuadradoTabPage.SuspendLayout();
            this.CirculoTabPage.SuspendLayout();
            this.RectanguloTabPage.SuspendLayout();
            this.PentagonoTabPage.SuspendLayout();
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
            this.trianguloTabPage.Controls.Add(this.trianguloLado1Label);
            this.trianguloTabPage.Controls.Add(this.trianguloLado1TextBox);
            this.trianguloTabPage.Controls.Add(this.trianguloLado2Label);
            this.trianguloTabPage.Controls.Add(this.trianguloLado2TextBox);
            this.trianguloTabPage.Controls.Add(this.trianguloLado3Label);
            this.trianguloTabPage.Controls.Add(this.trianguloLado3TextBox);
            this.trianguloTabPage.Controls.Add(this.trianguloAlturaLabel);
            this.trianguloTabPage.Controls.Add(this.trianguloAlturaTextBox);
            this.trianguloTabPage.Controls.Add(this.trianguloBaseTextBox);
            this.trianguloTabPage.Controls.Add(this.trianguloBaseLabel);
            this.trianguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.trianguloTabPage.Name = "trianguloTabPage";
            this.trianguloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trianguloTabPage.Size = new System.Drawing.Size(746, 299);
            this.trianguloTabPage.TabIndex = 0;
            this.trianguloTabPage.Text = "Triangulo";
            this.trianguloTabPage.UseVisualStyleBackColor = true;
            this.trianguloTabPage.Click += new System.EventHandler(this.trianguloTabPage_Click);
            // 
            // cuadradoTabPage
            // 
            this.cuadradoTabPage.Controls.Add(this.CuadradoLadoTextBox);
            this.cuadradoTabPage.Controls.Add(this.CuadradoLadoLabel);
            this.cuadradoTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTabPage.Name = "cuadradoTabPage";
            this.cuadradoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cuadradoTabPage.Size = new System.Drawing.Size(746, 299);
            this.cuadradoTabPage.TabIndex = 1;
            this.cuadradoTabPage.Text = "Cuadrado";
            this.cuadradoTabPage.UseVisualStyleBackColor = true;
            // 
            // CirculoTabPage
            // 
            this.CirculoTabPage.Controls.Add(this.circuloRadioTextBox);
            this.CirculoTabPage.Controls.Add(this.circuloRadioLabel);
            this.CirculoTabPage.Controls.Add(this.circuloPerimetroTextBox);
            this.CirculoTabPage.Controls.Add(this.circuloDiametroLabel);
            this.CirculoTabPage.Location = new System.Drawing.Point(4, 22);
            this.CirculoTabPage.Name = "CirculoTabPage";
            this.CirculoTabPage.Size = new System.Drawing.Size(746, 299);
            this.CirculoTabPage.TabIndex = 2;
            this.CirculoTabPage.Text = "Circulo";
            this.CirculoTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanguloTabPage
            // 
            this.RectanguloTabPage.Controls.Add(this.rectanguloBaseTextBox);
            this.RectanguloTabPage.Controls.Add(this.rectanguloBaseLabel);
            this.RectanguloTabPage.Controls.Add(this.rectanguloAlturaTextBox);
            this.RectanguloTabPage.Controls.Add(this.rectanguloAlturaLabel);
            this.RectanguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanguloTabPage.Name = "RectanguloTabPage";
            this.RectanguloTabPage.Size = new System.Drawing.Size(746, 299);
            this.RectanguloTabPage.TabIndex = 3;
            this.RectanguloTabPage.Text = "Rectangulo";
            this.RectanguloTabPage.UseVisualStyleBackColor = true;
            this.RectanguloTabPage.Click += new System.EventHandler(this.RectanguloTabPage_Click);
            // 
            // PentagonoTabPage
            // 
            this.PentagonoTabPage.Controls.Add(this.pentagonoLadoTextBox);
            this.PentagonoTabPage.Controls.Add(this.pentagonLadoLabel);
            this.PentagonoTabPage.Controls.Add(this.pentagonoApotemaTextBox);
            this.PentagonoTabPage.Controls.Add(this.pentagonoApotemaLabel);
            this.PentagonoTabPage.Location = new System.Drawing.Point(4, 22);
            this.PentagonoTabPage.Name = "PentagonoTabPage";
            this.PentagonoTabPage.Size = new System.Drawing.Size(746, 299);
            this.PentagonoTabPage.TabIndex = 4;
            this.PentagonoTabPage.Text = "Pentagono";
            this.PentagonoTabPage.UseVisualStyleBackColor = true;
            this.PentagonoTabPage.Click += new System.EventHandler(this.PentagonoTabPage_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(242, 31);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(290, 25);
            this.tituloLabel.TabIndex = 3;
            this.tituloLabel.Text = "Calculradora de Poligonos";
            this.tituloLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // trianguloBaseLabel
            // 
            this.trianguloBaseLabel.AutoSize = true;
            this.trianguloBaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trianguloBaseLabel.Location = new System.Drawing.Point(25, 29);
            this.trianguloBaseLabel.Name = "trianguloBaseLabel";
            this.trianguloBaseLabel.Size = new System.Drawing.Size(51, 18);
            this.trianguloBaseLabel.TabIndex = 0;
            this.trianguloBaseLabel.Text = "Base:";
            this.trianguloBaseLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // trianguloBaseTextBox
            // 
            this.trianguloBaseTextBox.Location = new System.Drawing.Point(95, 31);
            this.trianguloBaseTextBox.Name = "trianguloBaseTextBox";
            this.trianguloBaseTextBox.Size = new System.Drawing.Size(155, 20);
            this.trianguloBaseTextBox.TabIndex = 2;
            // 
            // trianguloAlturaTextBox
            // 
            this.trianguloAlturaTextBox.Location = new System.Drawing.Point(95, 72);
            this.trianguloAlturaTextBox.Name = "trianguloAlturaTextBox";
            this.trianguloAlturaTextBox.Size = new System.Drawing.Size(155, 20);
            this.trianguloAlturaTextBox.TabIndex = 3;
            // 
            // trianguloAlturaLabel
            // 
            this.trianguloAlturaLabel.AutoSize = true;
            this.trianguloAlturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trianguloAlturaLabel.Location = new System.Drawing.Point(25, 72);
            this.trianguloAlturaLabel.Name = "trianguloAlturaLabel";
            this.trianguloAlturaLabel.Size = new System.Drawing.Size(56, 18);
            this.trianguloAlturaLabel.TabIndex = 4;
            this.trianguloAlturaLabel.Text = "Altura:";
            this.trianguloAlturaLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // trianguloLado3Label
            // 
            this.trianguloLado3Label.AutoSize = true;
            this.trianguloLado3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trianguloLado3Label.Location = new System.Drawing.Point(25, 189);
            this.trianguloLado3Label.Name = "trianguloLado3Label";
            this.trianguloLado3Label.Size = new System.Drawing.Size(64, 18);
            this.trianguloLado3Label.TabIndex = 6;
            this.trianguloLado3Label.Text = "Lado 3:";
            this.trianguloLado3Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // trianguloLado3TextBox
            // 
            this.trianguloLado3TextBox.Location = new System.Drawing.Point(95, 189);
            this.trianguloLado3TextBox.Name = "trianguloLado3TextBox";
            this.trianguloLado3TextBox.Size = new System.Drawing.Size(155, 20);
            this.trianguloLado3TextBox.TabIndex = 5;
            this.trianguloLado3TextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // trianguloLado2Label
            // 
            this.trianguloLado2Label.AutoSize = true;
            this.trianguloLado2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trianguloLado2Label.Location = new System.Drawing.Point(25, 152);
            this.trianguloLado2Label.Name = "trianguloLado2Label";
            this.trianguloLado2Label.Size = new System.Drawing.Size(64, 18);
            this.trianguloLado2Label.TabIndex = 8;
            this.trianguloLado2Label.Text = "Lado 2:";
            // 
            // trianguloLado2TextBox
            // 
            this.trianguloLado2TextBox.Location = new System.Drawing.Point(95, 152);
            this.trianguloLado2TextBox.Name = "trianguloLado2TextBox";
            this.trianguloLado2TextBox.Size = new System.Drawing.Size(155, 20);
            this.trianguloLado2TextBox.TabIndex = 7;
            // 
            // trianguloLado1TextBox
            // 
            this.trianguloLado1TextBox.Location = new System.Drawing.Point(95, 114);
            this.trianguloLado1TextBox.Name = "trianguloLado1TextBox";
            this.trianguloLado1TextBox.Size = new System.Drawing.Size(155, 20);
            this.trianguloLado1TextBox.TabIndex = 9;
            // 
            // trianguloLado1Label
            // 
            this.trianguloLado1Label.AutoSize = true;
            this.trianguloLado1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trianguloLado1Label.Location = new System.Drawing.Point(25, 114);
            this.trianguloLado1Label.Name = "trianguloLado1Label";
            this.trianguloLado1Label.Size = new System.Drawing.Size(64, 18);
            this.trianguloLado1Label.TabIndex = 10;
            this.trianguloLado1Label.Text = "Lado 1:";
            this.trianguloLado1Label.Click += new System.EventHandler(this.lado1Label_Click);
            // 
            // CuadradoLadoLabel
            // 
            this.CuadradoLadoLabel.AutoSize = true;
            this.CuadradoLadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuadradoLadoLabel.Location = new System.Drawing.Point(15, 32);
            this.CuadradoLadoLabel.Name = "CuadradoLadoLabel";
            this.CuadradoLadoLabel.Size = new System.Drawing.Size(50, 18);
            this.CuadradoLadoLabel.TabIndex = 11;
            this.CuadradoLadoLabel.Text = "Lado:";
            // 
            // CuadradoLadoTextBox
            // 
            this.CuadradoLadoTextBox.Location = new System.Drawing.Point(71, 30);
            this.CuadradoLadoTextBox.Name = "CuadradoLadoTextBox";
            this.CuadradoLadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CuadradoLadoTextBox.TabIndex = 12;
            // 
            // circuloPerimetroTextBox
            // 
            this.circuloPerimetroTextBox.Location = new System.Drawing.Point(108, 70);
            this.circuloPerimetroTextBox.Name = "circuloPerimetroTextBox";
            this.circuloPerimetroTextBox.Size = new System.Drawing.Size(100, 20);
            this.circuloPerimetroTextBox.TabIndex = 14;
            // 
            // circuloDiametroLabel
            // 
            this.circuloDiametroLabel.AutoSize = true;
            this.circuloDiametroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuloDiametroLabel.Location = new System.Drawing.Point(20, 72);
            this.circuloDiametroLabel.Name = "circuloDiametroLabel";
            this.circuloDiametroLabel.Size = new System.Drawing.Size(82, 18);
            this.circuloDiametroLabel.TabIndex = 13;
            this.circuloDiametroLabel.Text = "Diametro:";
            // 
            // circuloRadioTextBox
            // 
            this.circuloRadioTextBox.Location = new System.Drawing.Point(108, 30);
            this.circuloRadioTextBox.Name = "circuloRadioTextBox";
            this.circuloRadioTextBox.Size = new System.Drawing.Size(100, 20);
            this.circuloRadioTextBox.TabIndex = 16;
            // 
            // circuloRadioLabel
            // 
            this.circuloRadioLabel.AutoSize = true;
            this.circuloRadioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuloRadioLabel.Location = new System.Drawing.Point(20, 30);
            this.circuloRadioLabel.Name = "circuloRadioLabel";
            this.circuloRadioLabel.Size = new System.Drawing.Size(57, 18);
            this.circuloRadioLabel.TabIndex = 15;
            this.circuloRadioLabel.Text = "Radio:";
            // 
            // rectanguloBaseTextBox
            // 
            this.rectanguloBaseTextBox.Location = new System.Drawing.Point(79, 25);
            this.rectanguloBaseTextBox.Name = "rectanguloBaseTextBox";
            this.rectanguloBaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectanguloBaseTextBox.TabIndex = 20;
            // 
            // rectanguloBaseLabel
            // 
            this.rectanguloBaseLabel.AutoSize = true;
            this.rectanguloBaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectanguloBaseLabel.Location = new System.Drawing.Point(19, 27);
            this.rectanguloBaseLabel.Name = "rectanguloBaseLabel";
            this.rectanguloBaseLabel.Size = new System.Drawing.Size(51, 18);
            this.rectanguloBaseLabel.TabIndex = 19;
            this.rectanguloBaseLabel.Text = "Base:";
            // 
            // rectanguloAlturaTextBox
            // 
            this.rectanguloAlturaTextBox.Location = new System.Drawing.Point(79, 69);
            this.rectanguloAlturaTextBox.Name = "rectanguloAlturaTextBox";
            this.rectanguloAlturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectanguloAlturaTextBox.TabIndex = 18;
            // 
            // rectanguloAlturaLabel
            // 
            this.rectanguloAlturaLabel.AutoSize = true;
            this.rectanguloAlturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectanguloAlturaLabel.Location = new System.Drawing.Point(17, 69);
            this.rectanguloAlturaLabel.Name = "rectanguloAlturaLabel";
            this.rectanguloAlturaLabel.Size = new System.Drawing.Size(56, 18);
            this.rectanguloAlturaLabel.TabIndex = 17;
            this.rectanguloAlturaLabel.Text = "Altura:";
            // 
            // pentagonoLadoTextBox
            // 
            this.pentagonoLadoTextBox.Location = new System.Drawing.Point(105, 15);
            this.pentagonoLadoTextBox.Name = "pentagonoLadoTextBox";
            this.pentagonoLadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.pentagonoLadoTextBox.TabIndex = 24;
            // 
            // pentagonLadoLabel
            // 
            this.pentagonLadoLabel.AutoSize = true;
            this.pentagonLadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pentagonLadoLabel.Location = new System.Drawing.Point(22, 17);
            this.pentagonLadoLabel.Name = "pentagonLadoLabel";
            this.pentagonLadoLabel.Size = new System.Drawing.Size(50, 18);
            this.pentagonLadoLabel.TabIndex = 23;
            this.pentagonLadoLabel.Text = "Lado:";
            // 
            // pentagonoApotemaTextBox
            // 
            this.pentagonoApotemaTextBox.Location = new System.Drawing.Point(105, 57);
            this.pentagonoApotemaTextBox.Name = "pentagonoApotemaTextBox";
            this.pentagonoApotemaTextBox.Size = new System.Drawing.Size(100, 20);
            this.pentagonoApotemaTextBox.TabIndex = 22;
            // 
            // pentagonoApotemaLabel
            // 
            this.pentagonoApotemaLabel.AutoSize = true;
            this.pentagonoApotemaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pentagonoApotemaLabel.Location = new System.Drawing.Point(20, 59);
            this.pentagonoApotemaLabel.Name = "pentagonoApotemaLabel";
            this.pentagonoApotemaLabel.Size = new System.Drawing.Size(79, 18);
            this.pentagonoApotemaLabel.TabIndex = 21;
            this.pentagonoApotemaLabel.Text = "Apotema:";
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
            this.trianguloTabPage.ResumeLayout(false);
            this.trianguloTabPage.PerformLayout();
            this.cuadradoTabPage.ResumeLayout(false);
            this.cuadradoTabPage.PerformLayout();
            this.CirculoTabPage.ResumeLayout(false);
            this.CirculoTabPage.PerformLayout();
            this.RectanguloTabPage.ResumeLayout(false);
            this.RectanguloTabPage.PerformLayout();
            this.PentagonoTabPage.ResumeLayout(false);
            this.PentagonoTabPage.PerformLayout();
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
        private System.Windows.Forms.TextBox trianguloAlturaTextBox;
        private System.Windows.Forms.TextBox trianguloBaseTextBox;
        private System.Windows.Forms.Label trianguloBaseLabel;
        private System.Windows.Forms.Label trianguloAlturaLabel;
        private System.Windows.Forms.TextBox trianguloLado1TextBox;
        private System.Windows.Forms.Label trianguloLado2Label;
        private System.Windows.Forms.TextBox trianguloLado2TextBox;
        private System.Windows.Forms.Label trianguloLado3Label;
        private System.Windows.Forms.TextBox trianguloLado3TextBox;
        private System.Windows.Forms.Label trianguloLado1Label;
        private System.Windows.Forms.TextBox CuadradoLadoTextBox;
        private System.Windows.Forms.Label CuadradoLadoLabel;
        private System.Windows.Forms.TextBox circuloRadioTextBox;
        private System.Windows.Forms.Label circuloRadioLabel;
        private System.Windows.Forms.TextBox circuloPerimetroTextBox;
        private System.Windows.Forms.Label circuloDiametroLabel;
        private System.Windows.Forms.TextBox rectanguloBaseTextBox;
        private System.Windows.Forms.Label rectanguloBaseLabel;
        private System.Windows.Forms.TextBox rectanguloAlturaTextBox;
        private System.Windows.Forms.Label rectanguloAlturaLabel;
        private System.Windows.Forms.TextBox pentagonoLadoTextBox;
        private System.Windows.Forms.Label pentagonLadoLabel;
        private System.Windows.Forms.TextBox pentagonoApotemaTextBox;
        private System.Windows.Forms.Label pentagonoApotemaLabel;
    }
}

