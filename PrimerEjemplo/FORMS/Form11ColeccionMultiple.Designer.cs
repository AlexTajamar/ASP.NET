namespace NetCoreFundametos.FORMS
{
    partial class Form11ColeccionMultiple
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
            lblIdex = new Label();
            lblItems = new Label();
            label2 = new Label();
            btnElimSeleccionados = new Button();
            btnBorrar = new Button();
            btnIns = new Button();
            txtElement = new TextBox();
            lstElementos = new ListBox();
            label1 = new Label();
            btnVisualizar = new Button();
            SuspendLayout();
            // 
            // lblIdex
            // 
            lblIdex.AutoSize = true;
            lblIdex.Location = new Point(203, 197);
            lblIdex.Name = "lblIdex";
            lblIdex.Size = new Size(0, 15);
            lblIdex.TabIndex = 19;
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Location = new Point(121, 197);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(0, 15);
            lblItems.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 39);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 17;
            label2.Text = "label2";
            // 
            // btnElimSeleccionados
            // 
            btnElimSeleccionados.BackColor = Color.LightSalmon;
            btnElimSeleccionados.Location = new Point(385, 134);
            btnElimSeleccionados.Name = "btnElimSeleccionados";
            btnElimSeleccionados.Size = new Size(75, 23);
            btnElimSeleccionados.TabIndex = 16;
            btnElimSeleccionados.Text = "Eliminar";
            btnElimSeleccionados.UseVisualStyleBackColor = false;
            btnElimSeleccionados.Click += btnElimSeleccionados_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(385, 163);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "BorrarTodo";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnIns
            // 
            btnIns.Location = new Point(385, 105);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(75, 23);
            btnIns.TabIndex = 14;
            btnIns.Text = "Insertar";
            btnIns.UseVisualStyleBackColor = true;
            btnIns.Click += btnIns_Click;
            // 
            // txtElement
            // 
            txtElement.Location = new Point(376, 76);
            txtElement.Name = "txtElement";
            txtElement.Size = new Size(100, 23);
            txtElement.TabIndex = 13;
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(121, 85);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 57);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(62, 15);
            label1.TabIndex = 11;
            label1.Text = "Elementos";
            // 
            // btnVisualizar
            // 
            btnVisualizar.Location = new Point(301, 197);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(248, 26);
            btnVisualizar.TabIndex = 20;
            btnVisualizar.Text = "VISUALIZAR SELECCIONADOS";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 250);
            Controls.Add(btnVisualizar);
            Controls.Add(lblIdex);
            Controls.Add(lblItems);
            Controls.Add(label2);
            Controls.Add(btnElimSeleccionados);
            Controls.Add(btnBorrar);
            Controls.Add(btnIns);
            Controls.Add(txtElement);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdex;
        private Label lblItems;
        private Label label2;
        private Button btnElimSeleccionados;
        private Button btnBorrar;
        private Button btnIns;
        private TextBox txtElement;
        private ListBox lstElementos;
        private Label label1;
        private Button btnVisualizar;
    }
}