namespace NetCoreFundametos.FORMS
{
    partial class Form18CheckRadios
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
            pnlBotones = new Panel();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            txtSuma = new TextBox();
            label1 = new Label();
            checkBox7 = new CheckBox();
            pnlBotones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(checkBox6);
            pnlBotones.Controls.Add(checkBox5);
            pnlBotones.Controls.Add(checkBox4);
            pnlBotones.Controls.Add(checkBox3);
            pnlBotones.Controls.Add(checkBox2);
            pnlBotones.Controls.Add(checkBox1);
            pnlBotones.Location = new Point(249, 199);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(331, 104);
            pnlBotones.TabIndex = 15;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(132, 56);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(83, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(230, 56);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(83, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(230, 18);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(36, 56);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(132, 18);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(36, 18);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(284, 147);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(215, 23);
            txtSuma.TabIndex = 13;
            txtSuma.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 151);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 12;
            label1.Text = "Contador";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(537, 148);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(83, 19);
            checkBox7.TabIndex = 16;
            checkBox7.Text = "checkBox7";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // Form18CheckRadios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox7);
            Controls.Add(pnlBotones);
            Controls.Add(txtSuma);
            Controls.Add(label1);
            Name = "Form18CheckRadios";
            Text = "Form18CheckRadios";
            pnlBotones.ResumeLayout(false);
            pnlBotones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlBotones;
        private TextBox txtSuma;
        private Label label1;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox7;
    }
}