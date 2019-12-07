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
            this.baseLabel = new System.Windows.Forms.Label();
            this.baseTextBox = new System.Windows.Forms.TextBox();
            this.alturaTextBox = new System.Windows.Forms.TextBox();
            this.alturaLabel = new System.Windows.Forms.Label();
            this.lado3Label = new System.Windows.Forms.Label();
            this.lado3TextBox = new System.Windows.Forms.TextBox();
            this.lado2Label = new System.Windows.Forms.Label();
            this.lado2TextBox = new System.Windows.Forms.TextBox();
            this.lado1TextBox = new System.Windows.Forms.TextBox();
            this.lado1Label = new System.Windows.Forms.Label();
            this.ladoLabel = new System.Windows.Forms.Label();
            this.LadotextBox = new System.Windows.Forms.TextBox();
            this.perimetroTextBox = new System.Windows.Forms.TextBox();
            this.diametroLabel = new System.Windows.Forms.Label();
            this.radioTextBox = new System.Windows.Forms.TextBox();
            this.radioLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.baseRectanguloLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.alturaRectanguloLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ladoPentagonoLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.apotemaLabel = new System.Windows.Forms.Label();
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
            this.trianguloTabPage.Controls.Add(this.lado1Label);
            this.trianguloTabPage.Controls.Add(this.lado1TextBox);
            this.trianguloTabPage.Controls.Add(this.lado2Label);
            this.trianguloTabPage.Controls.Add(this.lado2TextBox);
            this.trianguloTabPage.Controls.Add(this.lado3Label);
            this.trianguloTabPage.Controls.Add(this.lado3TextBox);
            this.trianguloTabPage.Controls.Add(this.alturaLabel);
            this.trianguloTabPage.Controls.Add(this.alturaTextBox);
            this.trianguloTabPage.Controls.Add(this.baseTextBox);
            this.trianguloTabPage.Controls.Add(this.baseLabel);
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
            this.cuadradoTabPage.Controls.Add(this.LadotextBox);
            this.cuadradoTabPage.Controls.Add(this.ladoLabel);
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
            this.CirculoTabPage.Controls.Add(this.radioTextBox);
            this.CirculoTabPage.Controls.Add(this.radioLabel);
            this.CirculoTabPage.Controls.Add(this.perimetroTextBox);
            this.CirculoTabPage.Controls.Add(this.diametroLabel);
            this.CirculoTabPage.Location = new System.Drawing.Point(4, 22);
            this.CirculoTabPage.Name = "CirculoTabPage";
            this.CirculoTabPage.Size = new System.Drawing.Size(746, 299);
            this.CirculoTabPage.TabIndex = 2;
            this.CirculoTabPage.Text = "Circulo";
            this.CirculoTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanguloTabPage
            // 
            this.RectanguloTabPage.Controls.Add(this.textBox1);
            this.RectanguloTabPage.Controls.Add(this.baseRectanguloLabel);
            this.RectanguloTabPage.Controls.Add(this.textBox2);
            this.RectanguloTabPage.Controls.Add(this.alturaRectanguloLabel);
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
            this.PentagonoTabPage.Controls.Add(this.textBox3);
            this.PentagonoTabPage.Controls.Add(this.ladoPentagonoLabel);
            this.PentagonoTabPage.Controls.Add(this.textBox4);
            this.PentagonoTabPage.Controls.Add(this.apotemaLabel);
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
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(25, 29);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(51, 18);
            this.baseLabel.TabIndex = 0;
            this.baseLabel.Text = "Base:";
            this.baseLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // baseTextBox
            // 
            this.baseTextBox.Location = new System.Drawing.Point(95, 31);
            this.baseTextBox.Name = "baseTextBox";
            this.baseTextBox.Size = new System.Drawing.Size(155, 20);
            this.baseTextBox.TabIndex = 2;
            // 
            // alturaTextBox
            // 
            this.alturaTextBox.Location = new System.Drawing.Point(95, 72);
            this.alturaTextBox.Name = "alturaTextBox";
            this.alturaTextBox.Size = new System.Drawing.Size(155, 20);
            this.alturaTextBox.TabIndex = 3;
            // 
            // alturaLabel
            // 
            this.alturaLabel.AutoSize = true;
            this.alturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaLabel.Location = new System.Drawing.Point(25, 72);
            this.alturaLabel.Name = "alturaLabel";
            this.alturaLabel.Size = new System.Drawing.Size(56, 18);
            this.alturaLabel.TabIndex = 4;
            this.alturaLabel.Text = "Altura:";
            this.alturaLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // lado3Label
            // 
            this.lado3Label.AutoSize = true;
            this.lado3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lado3Label.Location = new System.Drawing.Point(25, 189);
            this.lado3Label.Name = "lado3Label";
            this.lado3Label.Size = new System.Drawing.Size(64, 18);
            this.lado3Label.TabIndex = 6;
            this.lado3Label.Text = "Lado 3:";
            this.lado3Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // lado3TextBox
            // 
            this.lado3TextBox.Location = new System.Drawing.Point(95, 189);
            this.lado3TextBox.Name = "lado3TextBox";
            this.lado3TextBox.Size = new System.Drawing.Size(155, 20);
            this.lado3TextBox.TabIndex = 5;
            this.lado3TextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lado2Label
            // 
            this.lado2Label.AutoSize = true;
            this.lado2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lado2Label.Location = new System.Drawing.Point(25, 152);
            this.lado2Label.Name = "lado2Label";
            this.lado2Label.Size = new System.Drawing.Size(64, 18);
            this.lado2Label.TabIndex = 8;
            this.lado2Label.Text = "Lado 2:";
            // 
            // lado2TextBox
            // 
            this.lado2TextBox.Location = new System.Drawing.Point(95, 152);
            this.lado2TextBox.Name = "lado2TextBox";
            this.lado2TextBox.Size = new System.Drawing.Size(155, 20);
            this.lado2TextBox.TabIndex = 7;
            // 
            // lado1TextBox
            // 
            this.lado1TextBox.Location = new System.Drawing.Point(95, 114);
            this.lado1TextBox.Name = "lado1TextBox";
            this.lado1TextBox.Size = new System.Drawing.Size(155, 20);
            this.lado1TextBox.TabIndex = 9;
            // 
            // lado1Label
            // 
            this.lado1Label.AutoSize = true;
            this.lado1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lado1Label.Location = new System.Drawing.Point(25, 114);
            this.lado1Label.Name = "lado1Label";
            this.lado1Label.Size = new System.Drawing.Size(64, 18);
            this.lado1Label.TabIndex = 10;
            this.lado1Label.Text = "Lado 1:";
            this.lado1Label.Click += new System.EventHandler(this.lado1Label_Click);
            // 
            // ladoLabel
            // 
            this.ladoLabel.AutoSize = true;
            this.ladoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladoLabel.Location = new System.Drawing.Point(15, 32);
            this.ladoLabel.Name = "ladoLabel";
            this.ladoLabel.Size = new System.Drawing.Size(50, 18);
            this.ladoLabel.TabIndex = 11;
            this.ladoLabel.Text = "Lado:";
            // 
            // LadotextBox
            // 
            this.LadotextBox.Location = new System.Drawing.Point(71, 30);
            this.LadotextBox.Name = "LadotextBox";
            this.LadotextBox.Size = new System.Drawing.Size(100, 20);
            this.LadotextBox.TabIndex = 12;
            // 
            // perimetroTextBox
            // 
            this.perimetroTextBox.Location = new System.Drawing.Point(108, 70);
            this.perimetroTextBox.Name = "perimetroTextBox";
            this.perimetroTextBox.Size = new System.Drawing.Size(100, 20);
            this.perimetroTextBox.TabIndex = 14;
            // 
            // diametroLabel
            // 
            this.diametroLabel.AutoSize = true;
            this.diametroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diametroLabel.Location = new System.Drawing.Point(20, 72);
            this.diametroLabel.Name = "diametroLabel";
            this.diametroLabel.Size = new System.Drawing.Size(82, 18);
            this.diametroLabel.TabIndex = 13;
            this.diametroLabel.Text = "Diametro:";
            // 
            // radioTextBox
            // 
            this.radioTextBox.Location = new System.Drawing.Point(108, 30);
            this.radioTextBox.Name = "radioTextBox";
            this.radioTextBox.Size = new System.Drawing.Size(100, 20);
            this.radioTextBox.TabIndex = 16;
            // 
            // radioLabel
            // 
            this.radioLabel.AutoSize = true;
            this.radioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLabel.Location = new System.Drawing.Point(20, 30);
            this.radioLabel.Name = "radioLabel";
            this.radioLabel.Size = new System.Drawing.Size(57, 18);
            this.radioLabel.TabIndex = 15;
            this.radioLabel.Text = "Radio:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // baseRectanguloLabel
            // 
            this.baseRectanguloLabel.AutoSize = true;
            this.baseRectanguloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseRectanguloLabel.Location = new System.Drawing.Point(19, 27);
            this.baseRectanguloLabel.Name = "baseRectanguloLabel";
            this.baseRectanguloLabel.Size = new System.Drawing.Size(51, 18);
            this.baseRectanguloLabel.TabIndex = 19;
            this.baseRectanguloLabel.Text = "Base:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // alturaRectanguloLabel
            // 
            this.alturaRectanguloLabel.AutoSize = true;
            this.alturaRectanguloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaRectanguloLabel.Location = new System.Drawing.Point(17, 69);
            this.alturaRectanguloLabel.Name = "alturaRectanguloLabel";
            this.alturaRectanguloLabel.Size = new System.Drawing.Size(56, 18);
            this.alturaRectanguloLabel.TabIndex = 17;
            this.alturaRectanguloLabel.Text = "Altura:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 24;
            // 
            // ladoPentagonoLabel
            // 
            this.ladoPentagonoLabel.AutoSize = true;
            this.ladoPentagonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladoPentagonoLabel.Location = new System.Drawing.Point(22, 17);
            this.ladoPentagonoLabel.Name = "ladoPentagonoLabel";
            this.ladoPentagonoLabel.Size = new System.Drawing.Size(50, 18);
            this.ladoPentagonoLabel.TabIndex = 23;
            this.ladoPentagonoLabel.Text = "Lado:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 22;
            // 
            // apotemaLabel
            // 
            this.apotemaLabel.AutoSize = true;
            this.apotemaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apotemaLabel.Location = new System.Drawing.Point(20, 59);
            this.apotemaLabel.Name = "apotemaLabel";
            this.apotemaLabel.Size = new System.Drawing.Size(79, 18);
            this.apotemaLabel.TabIndex = 21;
            this.apotemaLabel.Text = "Apotema:";
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
        private System.Windows.Forms.TextBox alturaTextBox;
        private System.Windows.Forms.TextBox baseTextBox;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label alturaLabel;
        private System.Windows.Forms.TextBox lado1TextBox;
        private System.Windows.Forms.Label lado2Label;
        private System.Windows.Forms.TextBox lado2TextBox;
        private System.Windows.Forms.Label lado3Label;
        private System.Windows.Forms.TextBox lado3TextBox;
        private System.Windows.Forms.Label lado1Label;
        private System.Windows.Forms.TextBox LadotextBox;
        private System.Windows.Forms.Label ladoLabel;
        private System.Windows.Forms.TextBox radioTextBox;
        private System.Windows.Forms.Label radioLabel;
        private System.Windows.Forms.TextBox perimetroTextBox;
        private System.Windows.Forms.Label diametroLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label baseRectanguloLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label alturaRectanguloLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label ladoPentagonoLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label apotemaLabel;
    }
}

