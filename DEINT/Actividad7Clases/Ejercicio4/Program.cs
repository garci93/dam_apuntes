using Ejercicio4;

Persona persona = new Persona("Horacio",53);
Empleado empleado = new Empleado("Ana",27,1356);

Console.WriteLine(persona.Nombre);
Console.WriteLine(persona.Edad);
Console.WriteLine(persona.toString());
Console.WriteLine(empleado.Nombre);
Console.WriteLine(empleado.Edad);
Console.WriteLine(empleado.Sueldo);
empleado.MostrarSueldo();
Console.WriteLine(empleado.toString());