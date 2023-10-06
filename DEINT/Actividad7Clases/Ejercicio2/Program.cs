//Crea un programa que permita jugar a los dados. Para ello debes crear dos clases:
//      a.Dado: con atributo valor y métodos Tirar, que generará un aleatorio entre 1 y 6, y
//          un método Imprimir que mostrará el valor del dado.
//      b. Juego: con un atributo que será un array de tamaño 3 con objetos de tipo Dado y
//          un método Jugar, que debe tirar los tres dados, mostrar su valor y decirnos si
//          hemos perdido o ganado. Las reglas de juego son: se tiran tres dados si los tres
//          salen con el mismo valor mostrar un mensaje que "gano", sino "perdió".

using Ejercicio2;


Juego juego = new Juego();
juego.Jugar();