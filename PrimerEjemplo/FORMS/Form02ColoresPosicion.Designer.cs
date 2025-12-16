namespace NetCoreFundametos.FORMS
{
    partial class Form02ColoresPosicion
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
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtR = new TextBox();
            txtG = new TextBox();
            txtB = new TextBox();
            btnPosicion = new Button();
            btnCambiarColor = new Button();
            SuspendLayout();
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(117, 125);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 0;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(281, 125);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 93);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 2;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 93);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 3;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 53);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 229);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 5;
            label4.Text = "R";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 228);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 6;
            label5.Text = "G";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 228);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 7;
            label6.Text = "B";
            // 
            // txtR
            // 
            txtR.Location = new Point(130, 263);
            txtR.Name = "txtR";
            txtR.Size = new Size(100, 23);
            txtR.TabIndex = 8;
            // 
            // txtG
            // 
            txtG.Location = new Point(245, 263);
            txtG.Name = "txtG";
            txtG.Size = new Size(100, 23);
            txtG.TabIndex = 9;
            // 
            // txtB
            // 
            txtB.Location = new Point(367, 263);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 10;
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(420, 115);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(75, 40);
            btnPosicion.TabIndex = 11;
            btnPosicion.Text = "Cambiar Posicion";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(232, 329);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(139, 23);
            btnCambiarColor.TabIndex = 12;
            btnCambiarColor.Text = "Cambiar Color ";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btnCambiarColor_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(btnCambiarColor);
            Controls.Add(btnPosicion);
            Controls.Add(txtB);
            Controls.Add(txtG);
            Controls.Add(txtR);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPosX;
        private TextBox txtPosY;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private Button btnPosicion;
        private Button btnCambiarColor;
    }
}