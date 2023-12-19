using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        
    }
}
