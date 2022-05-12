using System;
using System.Text.RegularExpressions;

namespace ReduzString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma cadeia de caracteres contendo apenas: a, b , c");

            var cadeiaOriginal = Console.ReadLine();

            if (!Regex.IsMatch(cadeiaOriginal, @"^[a-c]+$"))
            {
                Console.WriteLine("Caracteres invalidos");
            }

            if (cadeiaOriginal.Length == 1)
            {
                Console.WriteLine(cadeiaOriginal);
            }

            var cadeia = cadeiaOriginal;

            do
            {
                for (var i = 0; i < cadeia.Length; i++)
                {
                    var par = "";

                    if (cadeia.Length > i + 1)
                    {
                        par = cadeia.Substring(i, 2);
                    }

                    if (par == "aa" || par == "bb" || par == "cc")
                    {
                        continue;
                    }
                    else if (par == "ab" || par == "ba")
                    {
                        cadeia = cadeia.Replace(par, "c");
                        continue;
                    }
                    else if (par == "ac" || par == "ca")
                    {
                        cadeia = cadeia.Replace(par, "b");
                        continue;
                    }
                    else if (par == "cb" || par == "bc")
                    {
                        cadeia = cadeia.Replace(par, "a");
                        continue;
                    }
                }

                if (cadeia.Length == 1) break;

                if (Iguais(cadeia)) break;

            } while (true);

            Console.WriteLine(cadeiaOriginal);

            Console.WriteLine(cadeia);

            Console.WriteLine(cadeia.Length);


            bool Iguais(string cadeia)
            {
                char comparar = cadeia[0];
                foreach (var item in cadeia)
                {
                    if (comparar != item) return false;
                }
                return true;
            }
        }

    }
}
