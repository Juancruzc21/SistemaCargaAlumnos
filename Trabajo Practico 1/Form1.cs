using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_1
{
    public partial class Form1 : Form
    {

        Cola miCola = new Cola();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            using (Form2 form2 = new Form2())
            {               
                if (form2.ShowDialog() == DialogResult.OK)
                {
                
                    Alumno nuevoAlumno = form2.Alumno;
                    miCola.Encolar(nuevoAlumno); 
                    MostrarCola(); 
                }
                else
                {                   
                    MessageBox.Show("Operación cancelada");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
            {
                MessageBox.Show("La cola esta vacia");
            }
            else
            {
                
                Alumno primerAlumno = miCola.Inicio;
                MessageBox.Show("El primer alumno de la cola es: " + primerAlumno.Nombre);

                miCola.Desencolar();
                MostrarCola();
            }
        }
        

        private void btnTope_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
            {
                MessageBox.Show("La cola está vacía");
            }
            else
            {
                Alumno primerAlumno = miCola.Inicio;
                MessageBox.Show("El alumno tope de la cola es: " + primerAlumno.Nombre);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();
            MostrarAlumnoEnPantalla(miCola.Inicio);
        }

        private void MostrarAlumnoEnPantalla(Alumno unAlumno)
        {
            if (unAlumno != null)
            {
                lstCola.Items.Add(unAlumno.Nombre);

                if (unAlumno.Siguiente != null)
                {
                    MostrarAlumnoEnPantalla(unAlumno.Siguiente);
                }

            }
        }
    }
}
