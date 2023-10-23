using Excepciones;
using System.Reflection.Metadata;

throw new Exception(); //Lanzamos un error, con la clase Exception

//Hay varios tipos de Excepciones, que heredan de la clase Exception

throw new NotImplementedException();

//Podemos personalizar el mensaje

throw new FileNotFoundException("El archivo de word no ha sido encontrado");


//Para evitar que el programa termine abruptamente con el error 

try
{
    //Código problame del error 

}
//indicamos el tipo de error que yo quiero atrapar, puede haber más de un catch
catch (NotImplementedException ex)
{
    Console.WriteLine("Ha ocurrido un error");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);

}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurrido una excepción general que no habia contemplado");
}

//A veces el bloque del try no se ejecuta por completo porque puede haber una excepción
//A veces el bloque del cath no se ejecuta porque puede no haber una excepción
//Para poner lo que queremos que siempre se ejecute 
finally
{
    Console.WriteLine("Este es el bloque del finally");

}


//Existen distintas clases que representan distintos tipos de excepciones
//Todas heredan de la clase Exception

//NotImplementedException 

//ArgumentException: Argumento o parámetro de una función no es válido
double Dividir (double dividendo, double divisor)
{
    if (divisor == 0)
    {
        throw new ArgumentException("El parámetro divisor debe ser distinto de cero");
    }
    return dividendo / divisor;
}


//ArgumentNullException: Excepción de argumento nulo 

void VolverMayusculas (string? s)
{
    if ( s is null)
    {
        throw new ArgumentNullException(nameof(s));
    }
    return s.ToUpper();
}

//DivideByZeroException

//FileNotFoundException 

//IndexOutOfRangeException : Intentamos acceder a una posición inexistente de un array 

//InvalidCastException: Cuando intentamos castear un objeto que no se puede 

int[] numeros = { 10, 20, 30 };

Castear(numeros);

void Castear ( object obj)
{
    var b = (bool)obj;
}

//NullReferenceException
int[]? numeros2 = null;

var longitud = numeros2.Length;


//OverflowException 

int valorMaximo = int.MaxValue;
valorMaximo++;

//StackOverflowException

MetodoA();

void MetodoA()
{
    MetodoB();
}

void MetodoB()
{
    MetodoA();
}

//Excepciones personalizadas
//Creamos una nueva clase que va a ser nuestra excepcion personalizada y ponemos que herede de Exception

throw new ExceptionPersonalizada();

throw new ExceptionPersonalizada("Este es un mensaje nuevo de Excepción ");

