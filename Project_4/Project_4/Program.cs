using System;
using System.Collections.Generic;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy nową listę
            List<int> listaLiczb = new List<int>();

            // Dodajemy elementy do listy
            listaLiczb.Add(1);
            listaLiczb.Add(2);
            listaLiczb.Add(3);

            // Wyświetlamy wszystkie elementy z listy
            foreach (int liczba in listaLiczb)
            {
                Console.WriteLine(liczba);
            }

            // Tworzymy nową kolejkę
            Queue<string> kolejkaSlow = new Queue<string>();

            // Dodajemy elementy do kolejki
            kolejkaSlow.Enqueue("Ala");
            kolejkaSlow.Enqueue("Ma");
            kolejkaSlow.Enqueue("Kota");

            // Wyświetlamy wszystkie elementy z kolejki
            foreach (string slowo in kolejkaSlow)
            {
                Console.WriteLine(slowo);
            }

            // Tworzymy nową stos
            Stack<double> stosLiczb = new Stack<double>();

            // Dodajemy elementy do stosu
            stosLiczb.Push(1.5);
            stosLiczb.Push(2.2);
            stosLiczb.Push(3.7);

            // Wyświetlamy wszystkie elementy ze stosu
            foreach (double liczba in stosLiczb)
            {
                Console.WriteLine(liczba);
            }

            // Tworzymy nową posortowaną listę
            SortedList<char, int> listaPosortowana = new SortedList<char, int>();

            // Dodajemy elementy do listy
            listaPosortowana.Add('a', 10);
            listaPosortowana.Add('b', 20);
            listaPosortowana.Add('c', 30);

            // Wyświetlamy wszystkie elementy z listy
            foreach (KeyValuePair<char, int> element in listaPosortowana)
            {
                Console.WriteLine("Klucz: {0}, Wartość: {1}", element.Key, element.Value);
            }

            // Tworzymy nowy słownik
            Dictionary<string, string> slownik = new Dictionary<string, string>();

            // Dodajemy elementy do słownika
            slownik.Add("pies", "dog");
            slownik.Add("kot", "cat");
            slownik.Add("koń", "horse");

            // Wyświetlamy wszystkie elementy ze słownika
            foreach (KeyValuePair<string, string> element in slownik)
            {
                Console.WriteLine("Klucz: {0}, Wartość: {1}", element.Key, element.Value);
            }

            Console.ReadKey();
        }
    }
}

/*
Kod powyżej demonstruje użycie kolekcji (List, Queue, Stack, SortedList, Dictionary) w języku C#.
Pierwszy przykład używa List<T>, dodaje trzy elementy i wyświetla je na konsolę.
Następnie tworzymy kolejkę Queue<T>, dodajemy trzy elementy i je wyświetlamy.
Następnie tworzymy stos Stack<T>, dodajemy trzy elementy i je wyświetlamy.
Później tworzymy posortowaną listę SortedList<TKey, TValue>, dodajemy trzy elementy i je wyświetlamy.
Na końcu tworzymy słownik Dictionary<TKey, TValue>, dodajemy trzy elementy i je wyświetlamy.
*/