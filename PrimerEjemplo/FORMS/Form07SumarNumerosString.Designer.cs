namespace NetCoreFundametos.FORMS
{
    partial class Form07SumarNumerosString
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
            txtCadena = new TextBox();
            label1 = new Label();
            btnCadena = new Button();
            lblSuma = new Label();
            SuspendLayout();
            // 
            // txtCadena
            // 
            txtCadena.Location = new Point(109, 79);
            txtCadena.Name = "txtCadena";
            txtCadena.Size = new Size(223, 23);
            txtCadena.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 53);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Cadena de Numeros";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCadena
            // 
            btnCadena.Location = new Point(109, 118);
            btnCadena.Name = "btnCadena";
            btnCadena.Size = new Size(221, 23);
            btnCadena.TabIndex = 2;
            btnCadena.Text = "Sumar Cadena ";
            btnCadena.UseVisualStyleBackColor = true;
            btnCadena.Click += btnCadena_Click;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(113, 166);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(37, 15);
            lblSuma.TabIndex = 3;
            lblSuma.Text = "Suma";
            // 
            // Form07SumarNumerosString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 251);
            Controls.Add(lblSuma);
            Controls.Add(btnCadena);
            Controls.Add(label1);
            Controls.Add(txtCadena);
            Name = "Form07SumarNumerosString";
            Text = "Form07SumarNumerosString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCadena;
        private Label label1;
        private Button btnCadena;
        private Label lblSuma;
    }
}