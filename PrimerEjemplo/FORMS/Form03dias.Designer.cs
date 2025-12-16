namespace NetCoreFundametos.FORMS
{
    partial class Form03dias
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
            button1 = new Button();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnio = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(105, 162);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(93, 29);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 1;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(93, 73);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 2;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(93, 115);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 3;
            // 
            // Form03dias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 206);
            Controls.Add(txtAnio);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(button1);
            Name = "Form03dias";
            Text = "Form03dias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnio;
    }
}