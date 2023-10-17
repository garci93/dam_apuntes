


//https://docs.microsoft.com/es-es/dotnet/standard/base-types/regular-expression-language-quick-reference
//Ejemplo 1 matches 
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


string regexp1 = @"\d{2}/\d{2}/\d{4}";
string regexp2 = @"^\w+@\w+\.\w{2,3}$";
string regexp3 = @"^\d{3}\-\d{3}\-\d{4}$";
string regexp4 = @"^([1-2]?\d{0,2}\.){3}[1-2]?\d{0,2}$";
string regexp5 = @"^([0-9-afA-F]{2}\-){5}[0-9-afA-F]{2}$";
char letra = 'a';
string regexp6 = @"^|\s"+letra+@"\w*";

bool ej1 = Regex.IsMatch("31/12/2001",regexp1);
bool ej2 = Regex.IsMatch("ejemplo@mail.es",regexp2);
bool ej3 = Regex.IsMatch("285-636-8535",regexp3);
bool ej4 = Regex.IsMatch("109.46.5.0",regexp4);
bool ej5 = Regex.IsMatch("00-A3-73-BC-D4-1F", regexp5);
bool ej6 = Regex.IsMatch("bardo avanzar regalo sesión ahora",regexp6);

Console.WriteLine(ej1);
Console.WriteLine(ej2);
Console.WriteLine(ej3);
Console.WriteLine(ej4);
Console.WriteLine(ej5);
Console.WriteLine(ej6);