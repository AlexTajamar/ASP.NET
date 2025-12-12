namespace PrimerEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.txtNombre.Location = new Point(200,100);
            this.txtNombre.Text = "soy un texto nuevo";
            this.txtNombre.Width = 200;
            this.txtNombre.TextAlign =  HorizontalAlignment.Center;
            this.txtNombre.BackColor = Color.Aqua;
        }
    }
}
