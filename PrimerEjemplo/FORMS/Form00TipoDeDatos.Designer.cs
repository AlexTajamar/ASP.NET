namespace PrimerEjemplo
{
    partial class Form00TipoDeDatos
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
            btnUno = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUno
            // 
            btnUno.BackColor = SystemColors.Highlight;
            btnUno.Location = new Point(260, 216);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(112, 37);
            btnUno.TabIndex = 0;
            btnUno.Text = "PÚLSAME";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += button1_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(164, 177);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(324, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 147);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 2;
            label1.Text = "Introduce tu nombre";
            // 
            // Form1
            // 
            AccessibleDescription = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(644, 308);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnUno);
            HelpButton = true;
            Name = "Form1";
            Text = "FormFirst";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUno;
        private TextBox txtNombre;
        private Label label1;
    }
}
