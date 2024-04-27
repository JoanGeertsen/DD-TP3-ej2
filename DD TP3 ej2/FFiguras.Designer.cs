namespace DD_TP3_ej2
{
    partial class FFiguras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pCreacio = new Panel();
            bAgregar = new Button();
            gbCuadrado = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            gbFigura = new GroupBox();
            rbRectangulo = new RadioButton();
            rbTriangulo = new RadioButton();
            rbCuadrado = new RadioButton();
            rbCirculo = new RadioButton();
            lbFiguras = new ListBox();
            bArea = new Button();
            bPerimetro = new Button();
            lCantidadCuadrados = new Label();
            l = new Label();
            pCreacio.SuspendLayout();
            gbCuadrado.SuspendLayout();
            gbFigura.SuspendLayout();
            SuspendLayout();
            // 
            // pCreacio
            // 
            pCreacio.BackColor = Color.PaleGreen;
            pCreacio.Controls.Add(bAgregar);
            pCreacio.Controls.Add(gbCuadrado);
            pCreacio.Controls.Add(gbFigura);
            pCreacio.Location = new Point(12, 12);
            pCreacio.Name = "pCreacio";
            pCreacio.Size = new Size(410, 151);
            pCreacio.TabIndex = 0;
            // 
            // bAgregar
            // 
            bAgregar.Location = new Point(321, 114);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(75, 34);
            bAgregar.TabIndex = 5;
            bAgregar.Text = "&Agregar";
            bAgregar.UseVisualStyleBackColor = true;
            // 
            // gbCuadrado
            // 
            gbCuadrado.Controls.Add(textBox1);
            gbCuadrado.Controls.Add(label1);
            gbCuadrado.Location = new Point(137, 12);
            gbCuadrado.Name = "gbCuadrado";
            gbCuadrado.Size = new Size(259, 96);
            gbCuadrado.TabIndex = 4;
            gbCuadrado.TabStop = false;
            gbCuadrado.Text = "Cuadrado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 47);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado:";
            // 
            // gbFigura
            // 
            gbFigura.Controls.Add(rbRectangulo);
            gbFigura.Controls.Add(rbTriangulo);
            gbFigura.Controls.Add(rbCuadrado);
            gbFigura.Controls.Add(rbCirculo);
            gbFigura.Location = new Point(12, 12);
            gbFigura.Name = "gbFigura";
            gbFigura.Size = new Size(103, 125);
            gbFigura.TabIndex = 1;
            gbFigura.TabStop = false;
            gbFigura.Text = "Figura";
            // 
            // rbRectangulo
            // 
            rbRectangulo.AutoSize = true;
            rbRectangulo.Location = new Point(6, 97);
            rbRectangulo.Name = "rbRectangulo";
            rbRectangulo.Size = new Size(85, 19);
            rbRectangulo.TabIndex = 3;
            rbRectangulo.Text = "Rectangulo";
            rbRectangulo.UseVisualStyleBackColor = true;
            // 
            // rbTriangulo
            // 
            rbTriangulo.AutoSize = true;
            rbTriangulo.Location = new Point(6, 72);
            rbTriangulo.Name = "rbTriangulo";
            rbTriangulo.Size = new Size(74, 19);
            rbTriangulo.TabIndex = 2;
            rbTriangulo.Text = "Triangulo";
            rbTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbCuadrado
            // 
            rbCuadrado.AutoSize = true;
            rbCuadrado.Checked = true;
            rbCuadrado.Location = new Point(6, 47);
            rbCuadrado.Name = "rbCuadrado";
            rbCuadrado.Size = new Size(77, 19);
            rbCuadrado.TabIndex = 1;
            rbCuadrado.TabStop = true;
            rbCuadrado.Text = "Cuadrado";
            rbCuadrado.UseVisualStyleBackColor = true;
            // 
            // rbCirculo
            // 
            rbCirculo.AutoSize = true;
            rbCirculo.Location = new Point(6, 22);
            rbCirculo.Name = "rbCirculo";
            rbCirculo.Size = new Size(63, 19);
            rbCirculo.TabIndex = 0;
            rbCirculo.Text = "Circulo";
            rbCirculo.UseVisualStyleBackColor = true;
            // 
            // lbFiguras
            // 
            lbFiguras.FormattingEnabled = true;
            lbFiguras.ItemHeight = 15;
            lbFiguras.Location = new Point(24, 169);
            lbFiguras.Name = "lbFiguras";
            lbFiguras.Size = new Size(301, 169);
            lbFiguras.TabIndex = 1;
            // 
            // bArea
            // 
            bArea.Location = new Point(333, 169);
            bArea.Name = "bArea";
            bArea.Size = new Size(75, 34);
            bArea.TabIndex = 6;
            bArea.Text = "&Area";
            bArea.UseVisualStyleBackColor = true;
            // 
            // bPerimetro
            // 
            bPerimetro.Location = new Point(333, 209);
            bPerimetro.Name = "bPerimetro";
            bPerimetro.Size = new Size(75, 34);
            bPerimetro.TabIndex = 7;
            bPerimetro.Text = "&Perímetro";
            bPerimetro.UseVisualStyleBackColor = true;
            // 
            // lCantidadCuadrados
            // 
            lCantidadCuadrados.AutoSize = true;
            lCantidadCuadrados.Location = new Point(30, 350);
            lCantidadCuadrados.Name = "lCantidadCuadrados";
            lCantidadCuadrados.Size = new Size(134, 15);
            lCantidadCuadrados.TabIndex = 8;
            lCantidadCuadrados.Text = "Cantidad de Cuadrados:";
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(31, 369);
            l.Name = "l";
            l.Size = new Size(143, 15);
            l.TabIndex = 9;
            l.Text = "Cantidad de Cuadrados: 0";
            // 
            // FFiguras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 450);
            Controls.Add(l);
            Controls.Add(lCantidadCuadrados);
            Controls.Add(bPerimetro);
            Controls.Add(bArea);
            Controls.Add(lbFiguras);
            Controls.Add(pCreacio);
            Name = "FFiguras";
            Text = "Figuras";
            pCreacio.ResumeLayout(false);
            gbCuadrado.ResumeLayout(false);
            gbCuadrado.PerformLayout();
            gbFigura.ResumeLayout(false);
            gbFigura.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pCreacio;
        private GroupBox gbFigura;
        private RadioButton rbRectangulo;
        private RadioButton rbTriangulo;
        private RadioButton rbCuadrado;
        private RadioButton rbCirculo;
        private Button bAgregar;
        private GroupBox gbCuadrado;
        private TextBox textBox1;
        private Label label1;
        private ListBox lbFiguras;
        private Button bArea;
        private Button bPerimetro;
        private Label lCantidadCuadrados;
        private Label l;
    }
}