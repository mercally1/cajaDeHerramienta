namespace cajaDeHerramienta
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Enabled = false;
        }

        private void controlBtn()
        {
            if (txt1.Text.Trim() != string.Empty && txt1.Text.All(Char.IsLetter))
            {
                btn1.Enabled = true;
                errorProvider1.SetError(txt1, "");
            }
            else
            {
                if (!(txt1.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txt1, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txt1, "Debe Introducir su nombre");
                }
                btn1.Enabled = false;
                txt1.Focus();
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            controlBtn();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            using (prestamo ventanaprestamo = new prestamo(txt1.Text))
                ventanaprestamo.ShowDialog();
        }
    }
}
