namespace NetCoreFundametos.FORMS
{
    partial class Form04ClasesWrappedMetodos
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
            txtDataTime = new TextBox();
            label1 = new Label();
            chkFormato = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            label2 = new Label();
            label3 = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // txtDataTime
            // 
            txtDataTime.Location = new Point(237, 64);
            txtDataTime.Name = "txtDataTime";
            txtDataTime.Size = new Size(314, 23);
            txtDataTime.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 46);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "FECHA actual";
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(243, 100);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(90, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "chkFormato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(243, 125);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "rdbDias";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(243, 150);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "rdbMeses";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(243, 175);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(76, 19);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "rdbAnyos";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(356, 139);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(192, 23);
            txtIncremento.TabIndex = 6;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(356, 168);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(192, 23);
            btnIncrementar.TabIndex = 7;
            btnIncrementar.Text = "INCREMENTAR";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 115);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 8;
            label2.Text = "Incremento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 256);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 9;
            label3.Text = "Fecha Final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(243, 274);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(305, 23);
            txtFechaFinal.TabIndex = 10;
            // 
            // Form04ClasesWrappedMetodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 362);
            Controls.Add(txtFechaFinal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(chkFormato);
            Controls.Add(label1);
            Controls.Add(txtDataTime);
            Name = "Form04ClasesWrappedMetodos";
            Text = "Form04ClasesWrappedMetodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDataTime;
        private Label label1;
        private CheckBox chkFormato;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label label2;
        private Label label3;
        private TextBox txtFechaFinal;
    }
}