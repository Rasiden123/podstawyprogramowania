using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Tworzę tablicę z trzema numerami 1,2,3, próbuję wyciągnąć czwórkę, której nie ma 
            // w tablicy.
            int[] numbers = { 1, 2, 3 };
            int index = 4;
            int result = numbers[index];
        }
        catch (IndexOutOfRangeException e)
        {
            // Zwrotna wiadomość
            Console.WriteLine("Indeks poza zakresem!");
        }
        finally
        {
            // Zamknięcie programu, niezależnie od tego czy liczba była w tablicy.
            Console.WriteLine("Koniec programu.");
        }
    }
}