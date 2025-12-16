namespace NetCoreFundametos.FORMS
{
    partial class Form05Char
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMultiLetras = new TextBox();
            txtMultiNumeros = new TextBox();
            label2 = new Label();
            txtMultiSimbolos = new TextBox();
            label3 = new Label();
            txtMultiPuntuacion = new TextBox();
            label4 = new Label();
            btnASCI = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // txtMultiLetras
            // 
            txtMultiLetras.Location = new Point(30, 51);
            txtMultiLetras.Multiline = true;
            txtMultiLetras.Name = "txtMultiLetras";
            txtMultiLetras.Size = new Size(100, 155);
            txtMultiLetras.TabIndex = 1;
            // 
            // txtMultiNumeros
            // 
            txtMultiNumeros.Location = new Point(136, 51);
            txtMultiNumeros.Multiline = true;
            txtMultiNumeros.Name = "txtMultiNumeros";
            txtMultiNumeros.Size = new Size(100, 155);
            txtMultiNumeros.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 29);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Numeros";
            // 
            // txtMultiSimbolos
            // 
            txtMultiSimbolos.Location = new Point(242, 51);
            txtMultiSimbolos.Multiline = true;
            txtMultiSimbolos.Name = "txtMultiSimbolos";
            txtMultiSimbolos.Size = new Size(100, 155);
            txtMultiSimbolos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 29);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Simbolos";
            // 
            // txtMultiPuntuacion
            // 
            txtMultiPuntuacion.Location = new Point(348, 51);
            txtMultiPuntuacion.Multiline = true;
            txtMultiPuntuacion.Name = "txtMultiPuntuacion";
            txtMultiPuntuacion.Size = new Size(100, 155);
            txtMultiPuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 29);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Puntuación";
            // 
            // btnASCI
            // 
            btnASCI.Location = new Point(170, 234);
            btnASCI.Name = "btnASCI";
            btnASCI.Size = new Size(144, 23);
            btnASCI.TabIndex = 8;
            btnASCI.Text = "Run ASCII";
            btnASCI.UseVisualStyleBackColor = true;
            btnASCI.Click += btnASCI_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 303);
            Controls.Add(btnASCI);
            Controls.Add(txtMultiPuntuacion);
            Controls.Add(label4);
            Controls.Add(txtMultiSimbolos);
            Controls.Add(label3);
            Controls.Add(txtMultiNumeros);
            Controls.Add(label2);
            Controls.Add(txtMultiLetras);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMultiLetras;
        private TextBox txtMultiNumeros;
        private Label label2;
        private TextBox txtMultiSimbolos;
        private Label label3;
        private TextBox txtMultiPuntuacion;
        private Label label4;
        private Button btnASCI;
    }
}