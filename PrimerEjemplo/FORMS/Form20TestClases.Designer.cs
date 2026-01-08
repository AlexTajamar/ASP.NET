namespace NetCoreFundametos.FORMS
{
    partial class Form20TestClases
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
            lstClases = new ListBox();
            btnCrearPersona = new Button();
            btnEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 58);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "datos";
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(44, 93);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(231, 94);
            lstClases.TabIndex = 1;
            // 
            // btnCrearPersona
            // 
            btnCrearPersona.Location = new Point(50, 224);
            btnCrearPersona.Name = "btnCrearPersona";
            btnCrearPersona.Size = new Size(187, 23);
            btnCrearPersona.TabIndex = 2;
            btnCrearPersona.Text = "Crear Persona";
            btnCrearPersona.UseVisualStyleBackColor = true;
            btnCrearPersona.Click += btnCrearPersona_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(58, 253);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(179, 23);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Crear Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(btnEmpleado);
            Controls.Add(btnCrearPersona);
            Controls.Add(lstClases);
            Controls.Add(label1);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstClases;
        private Button btnCrearPersona;
        private Button btnEmpleado;
    }
}