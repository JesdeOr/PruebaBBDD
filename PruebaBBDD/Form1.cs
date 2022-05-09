namespace PruebaBBDD
{
    public partial class Form1 : Form
    {
        ConexionBBDD c;
        public Form1()
        {            
            InitializeComponent();                        
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(c.Insertar(Convert.ToInt32(textBoxID.Text), textBoxNombre.Text, textBoxApellidos.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ingresar el usuario: \n" + ex.Message);
            }
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            c = new ConexionBBDD();
        }
    }
}