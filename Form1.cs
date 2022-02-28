using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3D
{
    public partial class Form1 : Form
    {

        

        List <Persona> personas = new List<Persona> ();



       // List<int> numeros = new List<int>();

        //List<string> texto = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            //Declarar un objeto llamado persona de la clase persona. 
            Persona persona = new Persona();
          
            persona.Dpi = textBoxDpi.Text;
            persona.Nombre = textBoxNombre.Text; 
            persona.Apellido = textBoxApellido.Text;
            persona.Telefono = textBoxTelefono.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;

            personas.Add(persona); //para agregar los datos de la persona a la lista 

        }

        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {

            // Persona persona = new Persona(); 

            /*labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelTelefono.Text = persona.Telefono;
            labelFechadeNacimiento.Text = persona.FechaNacimiento.ToString();
           
            labelEdad.Text = persona.edad().ToString();
           */

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            
            dataGridView1.DataSource = personas;
            dataGridView1.Refresh();


        }

        private void buttonAbrirCuenta_Click(object sender, EventArgs e)
        {
            FormCuenta formularioCuenta = new FormCuenta();
            formularioCuenta.Show();
        }

        private void buttoNGuardar_Click(object sender, EventArgs e)
        {
         //   FileStream stream = new FileStream (filename, FileMode).OpenCreate,

        }
    }
}
