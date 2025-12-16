namespace NetCoreFundametos.FORMS
{
    partial class Form09Isbn
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
            btnIsbn = new Button();
            txtIsbn = new TextBox();
            label1 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnIsbn
            // 
            btnIsbn.Location = new Point(90, 135);
            btnIsbn.Name = "btnIsbn";
            btnIsbn.Size = new Size(75, 23);
            btnIsbn.TabIndex = 0;
            btnIsbn.Text = "Conprobar";
            btnIsbn.UseVisualStyleBackColor = true;
            btnIsbn.Click += btnIsbn_Click;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(90, 87);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(254, 23);
            txtIsbn.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 60);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 2;
            label1.Text = "ISBN";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(90, 192);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 326);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(txtIsbn);
            Controls.Add(btnIsbn);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIsbn;
        private TextBox txtIsbn;
        private Label label1;
        private Label lblResultado;
    }
}