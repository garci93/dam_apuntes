using ExamenFinal.Repository;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
        
    [Table("Contacto")]
    public class Contacto : TableData
    {

        public Contacto()
        {
            Nombre = "Manuel";
            Foto = "Resources\\Images\\dotnet_bot.png";
            Correo = "a@b.c";
            Categoria = "Trabajo";
            Telefono = "666777888";
            Favorito = false;
        }

        public Contacto(string nombre, string foto, string correo, string categoria, string telefono, bool favorito)
        {
            Nombre = nombre;
            Foto = foto;
            Correo = correo;
            Categoria = categoria;
            Telefono = telefono;
            Favorito = favorito;
        }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("foto")]
        public string Foto { get; set; }
        [Column("correo")]
        public string Correo { get; set; }
        [Column("categoria")]
        public string Categoria { get; set; }
        [Column("telefono"), MaxLength(12)]
        public string Telefono { get; set; }
        [Column("favorito")]
        public bool Favorito { get; set; }
    }
}
