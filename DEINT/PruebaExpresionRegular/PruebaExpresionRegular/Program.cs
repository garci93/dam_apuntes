﻿


//https://docs.microsoft.com/es-es/dotnet/standard/base-types/regular-expression-language-quick-reference
//Ejemplo 1 matches 
using PruebaExpresionRegular;
using System.Text.RegularExpressions;

string frase = "A developer lives like olive oil – Always adding good taste to what they do?";
string patron = "[A]";

Regex regex = new Regex(patron);
MatchCollection matches1 = regex.Matches(frase);
int total = matches1.Count();

//Ejemplo 2 matches ignorando mayusc y minusc
string patron2 = "li";
MatchCollection matches2 = Regex.Matches(frase, patron2, RegexOptions.IgnoreCase);
foreach (Match match2 in matches2)
{
    Console.WriteLine(match2.Index);
}

//Ejemplo 3  match 
Match result3 = Regex.Match(frase, patron);

//Ejemplo4 ismatch

bool result4 = Regex.IsMatch(frase, patron);


//Ejemplo 5 Con caracter de escape 
Match result5 = Regex.Match(frase, @"do\?");


//Ejemplo 6 Conjuntos_ [ ] [ - ] [^] [^ - ] \d \D \w \s . 
Match result6 = Regex.Match(frase, @"[Aa]l");

Match result6b = Regex.Match(frase, @"[^Aa]l");

Match result6c = Regex.Match(frase, @"\w");

MatchCollection result6d = Regex.Matches(frase, @"\w");


//Ejemplo 7 Anchors ^ $ 

Match result7 = Regex.Match(frase, @"^\w");



//Ejemplo 8 Cuantificadores * + ? { } { ,} { , }

string frase8 = "Aquí tienes mi número de telefono (+34)666-66-66-66 y mi código 022-991";
string patron8 = @"\d{3}";
Regex regex8 = new Regex(patron8);
MatchCollection match8 = regex8.Matches(frase8);
int total2 = match8.Count();

//Categorias \p{categoria}

MatchCollection resultado = Regex.Matches(frase8, @"t\p{L}l");


//Grupos (  ) 

Match resultado2 = Regex.Match(frase8, @"(\d\d\d)-(\d\d\d)"); 


Console.WriteLine();


//Ejercicio expresiones regulares

string regexp1 = @"^\d{2}/\d{2}/\d{4}$";
string regexp2 = @"^\w+@\w+\.\w{2,3}$";
string regexp3 = @"\d{3}\-\d{3}\-\d{4}";
string regexp4 = @"^((1?\d{0,2}\.)|(2[0-4]\d)|(25[0-5])\.){3}[12]?\d{0,2}$";
string regexp5 = @"^([0-9-afA-F]{2}\-){5}[0-9-afA-F]{2}$";
char letra = 'a';
string regexp6 = $@"(^|\b){letra}\w*";

Pruebas prueba = new Pruebas();
bool ej1 = prueba.comprobar1(regexp1);
bool ej2 = prueba.comprobar2(regexp2);
bool ej3 = prueba.comprobar3(regexp3);
bool ej4 = prueba.comprobar4(regexp4);
bool ej5 = prueba.comprobar5(regexp5);
MatchCollection ej6 = prueba.comprobar6(regexp6);

Console.WriteLine(ej1);
Console.WriteLine(prueba.comprobar1a(regexp1));
Console.WriteLine(prueba.comprobar1b(regexp1));
Console.WriteLine(ej2);
Console.WriteLine(prueba.comprobar2a(regexp2));
Console.WriteLine(ej3);
Console.WriteLine(prueba.comprobar3a(regexp3));
Console.WriteLine(prueba.comprobar3b(regexp3));
Console.WriteLine(ej4);
Console.WriteLine(prueba.comprobar4a(regexp4));
Console.WriteLine(prueba.comprobar4b(regexp4));
Console.WriteLine(prueba.comprobar4c(regexp4));
Console.WriteLine(ej5);
Console.WriteLine(prueba.comprobar5a(regexp5));
Console.WriteLine(prueba.comprobar5b(regexp5));
Console.WriteLine(prueba.comprobar5c(regexp5));
foreach (var match in ej6)
{
    Console.WriteLine(match.ToString());
}