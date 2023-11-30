using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;

namespace Banco
{
    public class Banco
    {
        public List<Cliente> ClienteList { get; set; } = new List<Cliente>();

        public void addClienteXML(Cliente cliente) 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Banco));
            if (checkXMLExist())
            {
                ClienteList.Add(cliente);
                using (StreamWriter writer = new StreamWriter("banco.xml"))
                {
                    serializer.Serialize(writer, this);
                }      
            }
            else
            {
                ClienteList.Add(cliente);
                using (StreamWriter writer = new StreamWriter("banco.xml"))
                {
                    serializer.Serialize(writer, this);
                }
            }
            
        }

        public void addClienteJSON(Cliente cliente)
        {
            if (checkJsonExist())
            {
                ClienteList.Add(cliente);
                string fileName = "banco.json";
                string jsonString = JsonSerializer.Serialize(ClienteList);
                File.WriteAllText(fileName, jsonString);
            }
            else
            {
                ClienteList.Add(cliente);
                string fileName = "banco.json";
                string jsonString = JsonSerializer.Serialize(ClienteList);
                File.WriteAllText(fileName, jsonString);
            }

        }

        public void modifyClient(int index, Cliente cliente)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Banco));
            if (checkXMLExist())
            {
                using (StreamWriter writer = new StreamWriter("banco.xml"))
                {
                    ClienteList[index] = cliente;
                    serializer.Serialize(writer, this);
                }
            }
        }

        public void removeClient(int index)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Banco));
            if (checkXMLExist())
            {
                using (StreamWriter writer = new StreamWriter("banco.xml"))
                {
                    ClienteList.Remove(ClienteList[index]);
                    serializer.Serialize(writer, this);
                }
            }
        }

        public List<Cliente> DeserializeAndGetClientesXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Banco));
            using (StreamReader reader = new StreamReader("banco.xml"))
            {
                Banco banco = (Banco)serializer.Deserialize(reader);
                return banco.ClienteList;
            }
        }

        public List<Cliente> DeserializeAndGetClientesJson()
        {
            using (StreamReader reader = new StreamReader("banco.json"))
            {
                Banco banco = JsonSerializer.Deserialize<Banco>("banco.json");
                return banco.ClienteList;
            }
        }

        private bool checkXMLExist()
        {
            if(File.Exists("banco.xml"))
            {
                ClienteList = DeserializeAndGetClientesXML();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        private bool checkJsonExist()
        {
            if (File.Exists("banco.json"))
            {
                ClienteList = DeserializeAndGetClientesJson();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
