using System;
using System.Collections.Generic;

//Tworzenie kolekcji listy stringów
List<string> lista = new List<string> { "jeden", "dwa", "trzy" };

//Metoda przechodzenia przez parametry przekazywane przez wartość
static void MetodaPrzezWartosc(string element)
{
    Console.WriteLine("Element: {0}", element);
}

//Metoda przechodzenia przez parametry przekazywane przez referencję
static void MetodaPrzezReferencje(ref string element)
{
    element = "inny";
    Console.WriteLine("Element: {0}", element);
}

//Użycie metody przechodzenia przez wartość
foreach (string element in lista)
{
    MetodaPrzezWartosc(element);
}

//Użycie metody przechodzenia przez referencję
foreach (string element in lista)
{
    MetodaPrzezReferencje(ref element);
    Console.WriteLine("Element: {0}", element);
}