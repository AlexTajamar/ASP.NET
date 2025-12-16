namespace PrimerEjemplo
{
    public partial class Form00TipoDeDatos : Form
    {
        public Form00TipoDeDatos()
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

            //No es tipado automatico
            //int mayor = 88;
            //short pequeño = mayor;
            short pequeño = 88;
            int mayor = pequeño;


            //conversion string  a primtivo
            string numeroComoTexto = "1234";
            int numero = int.Parse(numeroComoTexto);
            double otroNumero = double.Parse(numeroComoTexto);

            //Casting
            int mayorCasting = 99;
            short pequeñoCasting = (short)mayorCasting;

            //Metodo toString
            string datoTexto = mayorCasting.ToString();


        }
    }
}
