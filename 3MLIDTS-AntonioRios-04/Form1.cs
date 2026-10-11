using System;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _3MLIDTS_AntonioRios_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tbNombre.TextChanged += ValidarNombre;
            tbApellido.TextChanged += ValidarApellido;
            tbEdad.TextChanged += ValidarEdad;
            tbEstatura.TextChanged += ValidarEstatura;
            tbTelefono.Leave += ValidarTelefono;
        }

        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textboxLocal = (TextBox)sender;
            if (!TelefonoValido(textboxLocal.Text))
            {
                MessageBox.Show("Escriba un telefono valido", "Error telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textboxLocal.BackColor = System.Drawing.Color.IndianRed;
                textboxLocal.Clear();

            }
            else
            {
                textboxLocal.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        private bool TelefonoValido(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) &&valor.Length==10;
        }


        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textboxLocal = (TextBox)sender;
            if (!EsDecimalValido(textboxLocal.Text))
            {
                MessageBox.Show("Escriba una Estatura valida", "Error Estatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textboxLocal.Clear();
            }
        }
        
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }

        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textboxLocal= (TextBox)sender;
            if (!EsTextoValido(textboxLocal.Text)) {
                MessageBox.Show("Escriba un Nombre valido","Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textboxLocal.Clear();
            
            }
        }

        private void ValidarApellido(object sender, EventArgs e)
        {
            TextBox textboxLocal = (TextBox)sender;
            if (!EsTextoValido(textboxLocal.Text))
            {
                MessageBox.Show("Escriba un Apellido valido", "Error Apellido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textboxLocal.Clear();

            }
        }

        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textLocal=(TextBox)sender;
            if (!EsEnteroValido(textLocal.Text))
            {
                MessageBox.Show("Escriba una Edad", "Error Edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textLocal.Clear();

            }


        }
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsTextoValido(string Valor)
        {
            return Regex.IsMatch(Valor, @"^[a-zA-Z\s]+$");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = tbNombre.Text;
            string Apellidos = tbApellido.Text;
            string Telefono = tbTelefono.Text;
            string Edad = tbEdad.Text;
            string Estatura = tbEstatura.Text;
            string genero = " ";

            if (rbMaculino.Checked)
            {
                genero = "Masculino";
            }

            else if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }

            else if (rbOtro.Checked)
            {

                genero = "otro";
            }

            string mensaje = $"Nombres: {nombres} \n Apellidos: {Apellidos}\n\r " +
                $"genero: {genero}\n\r Edad: {Edad}\n\r Telefono {Telefono}\n\r Estatura {Estatura}\n\r";


            string rutaFile = "C:\\Users\\Antonio Rios\\Documents\\3MAgosDic26.txt";
            bool archivoExiste = File.Exists(rutaFile);

            using (StreamWriter Escritor = new StreamWriter(rutaFile, true))
            {

                if (archivoExiste)
                {
                    Escritor.WriteLine();

                }

                Escritor.WriteLine(mensaje);

            }
            MessageBox.Show(mensaje, "Registros de Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gbGenero_Enter(object sender, EventArgs e)
        {

        }

        private void lbApelllido_Click(object sender, EventArgs e)
        {

        }

        private void lbEdad_Click(object sender, EventArgs e)
        {

        }

        private void lbTelefono_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
