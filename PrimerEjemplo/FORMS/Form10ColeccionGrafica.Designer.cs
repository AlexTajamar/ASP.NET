namespace NetCoreFundametos.FORMS
{
    partial class Form10ColeccionGrafica
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
            lstElementos = new ListBox();
            txtElement = new TextBox();
            btnIns = new Button();
            btnBorrar = new Button();
            btnElim = new Button();
            label2 = new Label();
            lblItems = new Label();
            lblIdex = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(12, 110);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 3;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // txtElement
            // 
            txtElement.Location = new Point(267, 101);
            txtElement.Name = "txtElement";
            txtElement.Size = new Size(100, 23);
            txtElement.TabIndex = 4;
            // 
            // btnIns
            // 
            btnIns.Location = new Point(276, 130);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(75, 23);
            btnIns.TabIndex = 5;
            btnIns.Text = "Insertar";
            btnIns.UseVisualStyleBackColor = true;
            btnIns.Click += btnIns_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(276, 188);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "BorrarTodo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnElim
            // 
            btnElim.Location = new Point(276, 159);
            btnElim.Name = "btnElim";
            btnElim.Size = new Size(75, 23);
            btnElim.TabIndex = 7;
            btnElim.Text = "Eliminar";
            btnElim.UseVisualStyleBackColor = true;
            btnElim.Click += btnElim_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 64);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Location = new Point(12, 222);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(0, 15);
            lblItems.TabIndex = 9;
            // 
            // lblIdex
            // 
            lblIdex.AutoSize = true;
            lblIdex.Location = new Point(94, 222);
            lblIdex.Name = "lblIdex";
            lblIdex.Size = new Size(0, 15);
            lblIdex.TabIndex = 10;
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 356);
            Controls.Add(lblIdex);
            Controls.Add(lblItems);
            Controls.Add(label2);
            Controls.Add(btnElim);
            Controls.Add(btnBorrar);
            Controls.Add(btnIns);
            Controls.Add(txtElement);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private TextBox txtElement;
        private Button btnIns;
        private Button btnBorrar;
        private Button btnElim;
        private Label label2;
        private Label lblItems;
        private Label lblIdex;
    }
}