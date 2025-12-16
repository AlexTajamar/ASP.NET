namespace NetCoreFundametos.FORMS
{
    partial class Form08StringBuilder
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
            txtTrabajar = new RichTextBox();
            label1 = new Label();
            lblTiempo = new Label();
            btnInvertir = new Button();
            btnInvertirStringBuilder = new Button();
            SuspendLayout();
            // 
            // txtTrabajar
            // 
            txtTrabajar.Location = new Point(104, 92);
            txtTrabajar.Name = "txtTrabajar";
            txtTrabajar.Size = new Size(183, 149);
            txtTrabajar.TabIndex = 0;
            txtTrabajar.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 58);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 1;
            label1.Text = "Copie este texto para trabajar";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(103, 255);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(56, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo : ";
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new Point(103, 301);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(75, 23);
            btnInvertir.TabIndex = 3;
            btnInvertir.Text = "Invertir String";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(219, 301);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(159, 23);
            btnInvertirStringBuilder.TabIndex = 4;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 397);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertir);
            Controls.Add(lblTiempo);
            Controls.Add(label1);
            Controls.Add(txtTrabajar);
            Name = "Form08StringBuilder";
            Text = "For08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTrabajar;
        private Label label1;
        private Label lblTiempo;
        private Button btnInvertir;
        private Button btnInvertirStringBuilder;
    }
}