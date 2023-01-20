using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dadaya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] mass = { 5, 7, 6, 2, -5, -4, -8 };
            //var res = mass.Where(E => E%2 == 0 && E < 0).Reverse();
            //foreach(var a in res)
            //    Console.Write($"{a}");
            //Console.ReadKey();

            //int[] mass = { -5, 7, 6, 2, -5, -4, -8, 5 };
            //var resF = mass.Where(e => e > 0).First();
            //var resL = mass.Where(e => e < 0).Last();
            //var resC = mass.Where(e => e > 0).Sum();
            //var resG = mass.Where(e => e > 0).Average();
            //var resH = mass.Where(e => e > 0).Count();
            //Console.Write($"{resF} {resL} {resC} {resG} {resH}");
            //Console.ReadKey();

            //Console.WriteLine("Введите число");
            //int L = Int32.Parse(Console.ReadLine());
            //string [] mass = { "Thomas", "Sergay", "Klicus", "Alesanders", "Joph", "Sam", "dadaya", "yma" };
            //try { var da = mass.Where(e => e.Length == L).Last(); Console.Write($"{da}"); }
            //catch { Console.WriteLine("Такого слова нет"); }
            //finally { Console.ReadKey(); };


            //LinqBegin16
            Console.WriteLine("LinqBegin16");
            Console.WriteLine("");
            int[] mass = { 5, 7, 6, 2, -5, -4, -8 };
            var t = mass.Where(e => e > 0);
            foreach (var ta in t)
                Console.Write($"{ta} ");

            //LinqBegin17
            Console.WriteLine("");
            Console.WriteLine("LinqBegin17");
            Console.WriteLine("");
            int[] mass1 = { 3, 5, 7, 6, 2, -5, -4, -8, 2, 10, 10, 7, 3};
            var d = mass1.Where(e => e % 2 != 0).Distinct();
            foreach (var da in d)
                Console.Write($"{da} ");

            //LinqBegin18
            Console.WriteLine("");
            Console.WriteLine("LinqBegin18");
            Console.WriteLine("");
            int[] mass2 = { 5, 7, 6, 2, -5, -4, -8 };
            var h = mass2.Where(e => e % 2 == 0 && e < 0).Reverse();
            foreach (var ha in h)
                Console.Write($"{ha} ");

            //LinqBegin19
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin19");
            Console.WriteLine("");
            Console.WriteLine("Введите число");
            int D = Int32.Parse(Console.ReadLine());
            int[] mass3 = { 2, -234, 52, -34, 56, 67, 43, -32, 54, 23, 32, 45, 65, 2, 76 };
            var g = mass3.Where(e => e > 0 && e % 10 == D).Reverse().Distinct().Reverse();
            try { foreach (var ga in g) Console.Write($"{ga} "); }
            catch { Console.WriteLine("Такого числа нет"); };

            //Что-то
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Что-то");
            Console.WriteLine("");
            Console.WriteLine("Введите число");
            int L = Int32.Parse(Console.ReadLine());
            string[] a = { "HFJGK67", "1ERTB6", "HFG6FH", "5TGH5", "HJKFL", "3H4J5K703" };
            var j = a.LastOrDefault(s => s.Length == L && Char.IsDigit(s[0]));
            Console.WriteLine(string.IsNullOrEmpty(j) ? "Not found" : j);

            //Что-то 2
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Что-то 2");
            Console.WriteLine("");
            Console.WriteLine("Введите букву");
            string C = Console.ReadLine();
            string[] A = { "ab", "abc", "addb", "adbd" };
            string result;
            try { result = A.Where(x => x.EndsWith(C)).SingleOrDefault(); }
            catch { result = "Error"; };
            Console.WriteLine(result);

            //Что-то 3
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Что-то 3");
            Console.WriteLine("");
            Console.WriteLine("Введите букву");
            string ch = Console.ReadLine();
            string[] AA = { "ab", "cac", "caddbc", "adbd", "cfc" };
            int result1;
            try { result1 = AA.Where(x => x.Length > 1 && x.StartsWith(ch) && x.EndsWith(ch)).Count(); Console.WriteLine(result1); }
            catch { Console.WriteLine("Error"); };

            //Что-то 4
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Что-то 4");
            Console.WriteLine("");
            string[] AAA = { "ab", "cac", "caddbc", "adbd", "cfc" };
            var result2 = AAA.Sum(x => x.Length);
            Console.WriteLine(result2);

            //Что-то 5
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Что-то 5");
            Console.WriteLine("");
            string[] AAAA = { "nab", "icac", "gcaddbc", "gadbd", "acfc" };
            string p = "";
            string result3 = AAAA.Aggregate(p, (x, y) => p += y[0]);
            Console.WriteLine(result3);

            //Что-то 6
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Что-то 6");
            Console.WriteLine("");
            string[] AAAAA = { "nab", "icac", "gcaddbc", "gadbd", "acfc" };
            var result4 = AAAAA.OrderBy(x => x.Length);
            string io = "";
            foreach(var rr in result4)
                io = io + rr + ", ";
            Console.WriteLine(io + ";");

            //Что-то 7
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Что-то 7");
            Console.WriteLine("");
            int[] AAAAAA = { 2, 3, 4, 0, -1, -8, 9, 1 };
            var result5 = AAAAAA.Select((x, i) => x * (i + 1)).Where(x => x > 9).Reverse();
            foreach(var rrr in result5)
                Console.WriteLine(rrr);

            Console.ReadKey();
        }
    }
}