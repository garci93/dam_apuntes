List<int> listaEnteros = new List<int>() {1,2,3};   //crear lista con elementos 1,2 y 3

Console.WriteLine(listaEnteros[0]);                 //mostrar elemento 0

listaEnteros.Add(2);                                //añadir 4 al final

listaEnteros.Remove(3);                             //borrar primer elemento con valor 3

listaEnteros.Insert(0, 6);                          //insertar el valor 6 en la posicion 0

foreach (int i in listaEnteros) 
    Console.WriteLine(i);

Console.WriteLine(listaEnteros.IndexOf(2));         //posicion de primer elemento con valor 2

Console.WriteLine(listaEnteros.LastIndexOf(2));     //posicion de ultimo elemento con valor 2

Dictionary<int, string> dic = new Dictionary<int, string>()
{
    [0] = "Ana",
    [1] = "Juan",
    [2] = "Pepe",
};

dic.Add(3, "Antonio");
dic[5] = "Maria";
dic.Remove(2);

if (!dic.ContainsKey(5))
    dic.Add(5, "Jose");

foreach (int i in dic.Keys)
{
    Console.WriteLine(dic[i]);
}

foreach (var i in dic)                          //!!!!!!!!!!!!!!!!!! Wow!!
{
    Console.WriteLine(i);
}