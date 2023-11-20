using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerializacionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(textBox1.Text, textBox2.Text, textBox3.Text);

            XmlSerializer serializer= new XmlSerializer(typeof(Persona));

            using (var stream = new FileStream("person.xml", FileMode.Create))
            {
                serializer.Serialize(stream, p);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Persona));

            using (var stream = new FileStream("person.xml", FileMode.Open))
            {
                var p2 = (Persona)serializer.Deserialize(stream);

                textBox1.Text = p2.DNI;
                textBox2.Text = p2.Nombre;
                textBox3.Text = p2.Apellidos;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Persona p = new Persona(textBox1.Text, textBox2.Text, textBox3.Text);

            
            using (var stream = new FileStream("person.json", FileMode.Create))
            {

                var options = new JsonSerializerOptions { WriteIndented = true };
                JsonSerializer.Serialize(stream, p, options);

                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (var stream = new FileStream("person.json", FileMode.Open))
            {
                var p2 = JsonSerializer.Deserialize<Persona>(stream);
                textBox1.Text = p2.DNI;
                textBox2.Text = p2.Nombre;
                textBox3.Text = p2.Apellidos;
            }

        }
    }
}
