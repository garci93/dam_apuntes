using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso
{
    public partial class Form1 : Form
    {
        private Servicio servicio = Servicio.GetInstance();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = servicio.GetPersonas().Tables[0];
            DAOPersonas.GetInstance().ModificarPersona(txtNombre.Text,int.Parse(txtEdad.Text));
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNombre.Text, @"^[A-Za-z]+$"))
            {
                errorProvider1.SetError(txtNombre, "El nombre es incorrecto");
            }
        }
    }
}
