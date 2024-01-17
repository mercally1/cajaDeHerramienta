using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace cajaDeHerramienta
{
    public partial class prestamo : Form
    {
        string nombre_cliente;
        string[] razas_disponibles = { "blanca", "caucásica", "negro", "africana", "africana", "africana", "roja", "amerindia" };
        int[] cuotas_disponibles = { 6, 12, 18, 24, 30, 36, 42, 48 };
        string[] lugares_disponibles;
        Dictionary<int, double> intereses_bases;

        public prestamo(string txt1)
        {
            InitializeComponent();

            nombre_cliente = txt1;
            //inclumos el archivo txt
            string lugares_cuidades = Properties.Resources.listado.ToString();
            lugares_disponibles = lugares_cuidades.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            
            intereses_bases = new Dictionary<int, double>();
            int i;
            double interes;
            for ( i = 0, interes = 3.0; i < cuotas_disponibles.Length; i++, interes +=  0.5 )
            {
                intereses_bases[cuotas_disponibles[i]] = interes;
            }
        }
        //
        private void prestamo_Load(object sender, EventArgs e)
        {
            popularCuotas();
            popularRaza();
            popularCiudad();
            saludo.Text += nombre_cliente;
        }

        void popularCuotas()
        {
            for (int i = 0; i < cuotas_disponibles.Length; i++)
            {
                comboBox5.Items.Add(cuotas_disponibles[i]);
            }
        }

        void popularRaza()
        {
            for (int i = 0; i < razas_disponibles.Length; i++)
            {
                comboBox1.Items.Add(razas_disponibles[i]);
            }
        }
        void popularCiudad()
        {
            for (int i = 0; i < lugares_disponibles.Length; i++)
            {
                comboBox2.Items.Add(lugares_disponibles[i]);
            }
        }
        //button volver
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //button confirmar
        double calcularInteres()
        {
            int cuotas_Pedidas = (int)comboBox5.SelectedItem;
            string razaSeleccionada = comboBox1.SelectedItem.ToString().ToLower();
            string lugarSeleccionada = comboBox2.SelectedItem.ToString().ToLower();
            double interes = intereses_bases[cuotas_Pedidas];
            if (new[] { "blanca", "caucásica", "negro", "africana", "africana" }.Contains(razaSeleccionada))
            {
                interes += 0.3;
            }
            else (new[] {"Albani", "Alemania", "Andorra", "Austria", "Bélgica", "Bielorrusia", "Bosnia", "Bulgaria"}.Contains(lugarSeleccionada))
            {
                interes -= 0.3;
            }
            return interes;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (validaciones())
            {
                case 0:
                    {
                        errorProvider1.SetError(datosPersonales, "");
                        errorProvider1.SetError(DetallePrestamo, "");
                        double interes_mensual = calcularInteres();
                        double monto_pedido = double.Parse(cuotas.Text);
                        int cuotas_Pedidas = (int)comboBox5.SelectedItem;
                        double interes_total = monto_pedido * (interes_mensual / 100) * cuotas_Pedidas;
                        double monto_a_pagar = monto_pedido + interes_total;
                        string mensaje = "Su prestamo por " + monto_pedido + " en " + cuotas_Pedidas +  " cuotas se concederácon un interes del" + interes_mensual + "mensual. \n El monto total a cancelar es de " + monto_a_pagar;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Calculo de intereses", buttons);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(datosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(DetallePrestamo, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(DetallePrestamo, "Debe completar los datos del detalle de prestamo");
                        errorProvider1.SetError(datosPersonales, "");
                        break;
                    }
            }
        }

        int validaciones()
        {
            if (!(comboBox1.SelectedIndex <= -1) || (comboBox2.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                if (!(cuotas.Text.All(Char.IsDigit)) || (cuotas.Text == "") || (comboBox5.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}