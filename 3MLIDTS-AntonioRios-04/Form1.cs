using System;
using System.IO;
using System.Windows.Forms;

namespace _3MLIDTS_AntonioRios_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
