using AdminIES.frm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminIES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ciclos_Click(object sender, EventArgs e)
        {
            frmCiclo frmCiclo = new frmCiclo();
            frmCiclo.ShowDialog();
        }

        private void estudiantes_Click(object sender, EventArgs e)
        {
            frmEstudiante frmEstudiante = new frmEstudiante();
            frmEstudiante.ShowDialog();
        }
    }
}
