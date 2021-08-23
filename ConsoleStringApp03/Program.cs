using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStringApp03
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = "The Lord of the rings";
            var keyPress = "";
            do
            {
                Console.Write("Ingrese un caracter y presione ENTER:");
                keyPress = Console.ReadLine();
                if (!ValidarLetra(keyPress))
                {
                    Console.WriteLine("No se ingresó caracter o el mismo no es válido");
                }
                else
                {
                    break;
                }

            } while (true);
            //var letter = 'o';
            var letter = Convert.ToChar(keyPress);
            int firstTime = 0, lastTime = 0, countLetter=0;
            if (phrase.Contains(letter))
            {
                countLetter = CountLetter(phrase, letter);
                firstTime = FindFirstLetter(phrase, letter);
                lastTime = FindLastLetter(phrase, letter);

            }
            //int countLetter = CountLetter(phrase, letter);
            //if (countLetter>0)
            //{
            //    firstTime = FindFirstLetter(phrase, letter);
            //    lastTime = FindLastLetter(phrase, letter);
            //}

            if (ContainsLetter(phrase, letter))
            {
                Console.WriteLine(countLetter == 1 ? $"Aparece una vez" : $"Aparece {countLetter} veces");
                Console.WriteLine($"Primero en la posición {firstTime}");
                if (countLetter>1)
                {
                    Console.WriteLine($"Y por última vez la posición {lastTime}"); 
                }

            }
            else
            {
                Console.WriteLine($"{phrase} no contiene a la letra {letter}");
            }
            Console.ReadLine();
        }

        private static bool ContainsLetter(string phrase, char letter)
        {
            return phrase.Contains(letter);
        }

        private static bool ValidarLetra(string keyPress)
        {
            return keyPress.Length == 1 && char.IsLetter(keyPress[0]);

        }

        private static int FindLastLetter(string phrase, char letter)
        {
            return phrase.LastIndexOf(letter);
        }

        private static int FindFirstLetter(string phrase, char letter)
        {
            return phrase.IndexOf(letter);
        }

        private static int CountLetter(string phrase, char letter)
        {
            //int count = 0;
            //foreach (var c in phrase)
            //{
            //    if (c==letter)
            //    {
            //        count++;
            //    }
            //}

            //return count;
            return phrase.Count(c => c == letter);
        }
    }
}
