namespace NetCoreFundametos
{
    partial class Form01SumarNumeros
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
            label2 = new Label();
            label3 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSumarNumero = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 28);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 96);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 170);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "Numero Resultado ";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(102, 59);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(102, 127);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 4;
            // 
            // btnSumarNumero
            // 
            btnSumarNumero.Location = new Point(243, 96);
            btnSumarNumero.Name = "btnSumarNumero";
            btnSumarNumero.Size = new Size(75, 23);
            btnSumarNumero.TabIndex = 5;
            btnSumarNumero.Text = "PÚLSAME";
            btnSumarNumero.UseVisualStyleBackColor = true;
            btnSumarNumero.Click += btnSumarNumero_Click;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 338);
            Controls.Add(btnSumarNumero);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSumarNumero;
    }
}