using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //Obtener datos de los Texbox
            string Nombre = textBox1.Text;
            string Apellidos = textBox2.Text;
            string Telefono = textBox3.Text;
            string Estatura = textBox4.Text;
            string Edad = textBox5.Text;

               string Genero = "";
            if (rdHombre .Checked )
            {
                Genero = "Hombre";
            }
            else if (rdMujer .Checked )
            {
                Genero = "Mujer";
            }
            //Crear una cadena de los datos
            string datos = $"Nombres:{Nombre}\r\nApellidos: {Apellidos}\r\ntelefono: {Telefono} \r\nestatura: {Estatura} mc\r\nedad: {Edad} años\r\ngenero: {Genero}";
            //Guardar los datos en un archivo de texto 
            string rutaArchivo = "C:/Users/ISAAC/OneDrive/Documentos/jaredtext";
            //File.WriteAllText(rutaArchivo, datos);
            //Verificar si el archivo existe 
            bool archivoExiste = File.Exists(rutaArchivo);
            //console.writeLine(ArchivoExiste);
            if (archivoExiste == false)
            {
                File.WriteAllText(rutaArchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }

                    writer.WriteLine(datos);
                }
            }//mostrar mensajes con los datos capturados 
            MessageBox.Show("Datos guardados con exito:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar los controles despues de guardar 
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            rdHombre.Checked = false;
            rdMujer.Checked = false;
        }
    }
}
