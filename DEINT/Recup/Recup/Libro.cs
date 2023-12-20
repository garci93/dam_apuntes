using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recup
{
    public class Libro
    {
        public enum TipoGenero
        {
            FANTASIA,CIENCIA_FICCION,TERROR,AVENTURA,COMEDIA,ROMANCE,BIOGRAFIA
        }
        public long ISBN {  get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public int AnioPublicacion { get; set; }
        public int Editorial {  get; set; }
        public TipoGenero Genero { get; set; }
        public Libro(){}
        public Libro(long iSBN, string titulo, string autor, int anioPublicacion, int editorial, TipoGenero genero)
        {
            ISBN = iSBN;
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
            Editorial = editorial;
            Genero = genero;
        }
    }
}
