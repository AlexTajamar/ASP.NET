namespace NetCoreFundametos.FORMS
{
    partial class Form12_1TiendaProductos
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
            label2 = new Label();
            label3 = new Label();
            btnNuevo = new Button();
            btnEliminar = new Button();
            button3 = new Button();
            btnIzquierda = new Button();
            btnTodosIzq = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            lstTienda = new ListBox();
            lstAlmacen = new ListBox();
            txtCosas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 32);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "TIENDA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 32);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "ALMACEN";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(44, 84);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(44, 122);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(44, 160);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Borrar Todo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnIzquierda
            // 
            btnIzquierda.Location = new Point(342, 94);
            btnIzquierda.Name = "btnIzquierda";
            btnIzquierda.Size = new Size(130, 23);
            btnIzquierda.TabIndex = 6;
            btnIzquierda.Text = "Seleccion -->";
            btnIzquierda.UseVisualStyleBackColor = true;
            btnIzquierda.Click += btnIzquierda_Click;
            // 
            // btnTodosIzq
            // 
            btnTodosIzq.Location = new Point(368, 151);
            btnTodosIzq.Name = "btnTodosIzq";
            btnTodosIzq.Size = new Size(75, 23);
            btnTodosIzq.TabIndex = 7;
            btnTodosIzq.Text = "Todos --> ";
            btnTodosIzq.UseVisualStyleBackColor = true;
            btnTodosIzq.Click += btnTodosIzq_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(663, 94);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 8;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(663, 160);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(75, 23);
            btnBajar.TabIndex = 9;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(202, 61);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(120, 229);
            lstTienda.TabIndex = 10;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(512, 61);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(120, 229);
            lstAlmacen.TabIndex = 11;
            // 
            // txtCosas
            // 
            txtCosas.Location = new Point(44, 55);
            txtCosas.Name = "txtCosas";
            txtCosas.Size = new Size(100, 23);
            txtCosas.TabIndex = 12;
            // 
            // Form12_1TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 503);
            Controls.Add(txtCosas);
            Controls.Add(lstAlmacen);
            Controls.Add(lstTienda);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodosIzq);
            Controls.Add(btnIzquierda);
            Controls.Add(button3);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12_1TiendaProductos";
            Text = "Form12_1TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button button3;
        private Button btnIzquierda;
        private Button btnTodosIzq;
        private Button btnSubir;
        private Button btnBajar;
        private ListBox lstTienda;
        private ListBox lstAlmacen;
        private TextBox txtCosas;
    }
}