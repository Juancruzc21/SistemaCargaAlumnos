﻿using System;
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
    public partial class Form2 : Form
    {
        public Alumno Alumno { get; private set; } 

        public Form2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtNombreAlumno.Text))
            {
                MessageBox.Show("Ingrese un nombre válido");
            }
            else
            {
                
                Alumno = new Alumno
                {
                    Nombre = txtNombreAlumno.Text
                };
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close(); 
        }
    }
}
