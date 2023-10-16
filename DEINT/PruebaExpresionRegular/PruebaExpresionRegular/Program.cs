


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


//Ejemplo 6 Conjuntos_ [ ] [ - ] [^] [^ - ] \d \D \w \s . \p 
Match result6 = Regex.Match(frase, @"[Aa]l");

Match result6b = Regex.Match(frase, @"[^Aa]l");

Match result6c = Regex.Match(frase, @"\w");

MatchCollection result6d = Regex.Matches(frase, @"\w");

//Ejemplo 7 Anchors ^ $ 

Match result7 = Regex.Match(frase, @"^\w");



//Ejemplo 8 Cuantificadores * + ? { } { ,} { , }

string frase8 = "Aquí tienes mi número de telefono (+34)666-66-66-66";
string patron8 = @"\d{3}";
Regex regex8 = new Regex(patron8);
MatchCollection match8 = regex8.Matches(frase8);
int total2 = match8.Count();

Console.WriteLine();
