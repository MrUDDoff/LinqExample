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
            //Console.WriteLine("Linq" + " " +
            //  "Begin16");
            //Console.WriteLine("");
            //int[] mass = { 5, 7, 6, 2, -5, -4, -8 };
            //var t = mass.Where(e => e > 0);
            //foreach (var ta in t)
              //  Console.Write($"{ta} ");

            //LinqBegin17
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin17");
            Console.WriteLine("");
            int[] mass1 = { 3, 5, 7, 6, 2, -5, -4, -8, 2, 10, 10, 7, 3};
            var d = mass1.Where(e => e % 2 != 0).Distinct();
            foreach (var da in d)
                Console.Write($"{da} ");

            //LinqBegin18
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin18");
            Console.WriteLine("");
            int[] mass2 = { 5, 7, 6, 2, -5, -4, -8 };
            var h = mass2.Where(e => e % 2 == 0 && e < 0).Reverse();
            foreach (var ha in h)
                Console.Write($"{ha} ");

            //LinqBegin19
            //Console.WriteLine("");
            //Console.WriteLine("Linq" + " " +
           //     "Begin19");
           // Console.WriteLine("");
          //  Console.WriteLine("Введите число");
           // int D = Int32.Parse(Console.ReadLine());
          //  int[] mass3 = { 2, -234, 52, -34, 56, 67, 43, -32, 54, 23, 32, 45, 65, 2, 76 };
          //  var g = mass3.Where(e => e > 0 && e % 10 == D).Reverse().Distinct().Reverse();
          //  try { foreach (var ga in g) Console.Write($"{ga} "); }
          //  catch { Console.WriteLine("Такого числа нет"); };

            //LinqBegin20
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin20");
            Console.WriteLine("");
            int[] mass4 = { 2, 3, 4, 0, -1, -8, 9, 1, 20, 10, -43, 12, 34, 333 };
            var u = mass4.Where(x => x > 9 && x < 100).OrderBy(x => x);
            foreach (var ua in u)
                Console.WriteLine($"{ua} ");

            //LinqBegin23
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin23");
            Console.WriteLine("");
            int k = 2;
            int[] mass5 = { 15, 2, 3, 4, 0, -1, -8, 9, 1, 20, 10, -43, 12, 34, 333 };
            var q = mass5.Where((x, i) => i >= k && x % 2 != 0).OrderByDescending(x => x);
            foreach (var qa in q)
                Console.WriteLine($"{qa} ");

            //LinqBegin24
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin24");
            Console.WriteLine("");
            int kk = 4;
            string[] mass6 = { "HFJGK67", "ERTB6", "hFG6FH", "5TGH5", "hJKFL", "H4J5K703" };
            var pop = mass6.Where((x, i) => i < kk && Char.IsUpper(x[0]) && x.Length % 2 != 0).Reverse();
            foreach (var popa in pop)
                Console.WriteLine(popa);

            //LinqBegin28
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin28");
            Console.WriteLine("");
            int ll = 2;
            string[] mass7 = { "HJ", "F1F", "GL1", "F55", "JTT", "31", "IOPSS" };
            var lol = mass7.TakeWhile((x, i) => x.Length >= ll && Char.IsLetter(x[x.Length - 1])).OrderByDescending(x => x.Length).ThenBy(x => x);
            foreach (var lola in lol)
                Console.WriteLine(lola);

            //LinqBegin33
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin33");
            Console.WriteLine("");
            int[] mass8 = { -12, 34, 56, -78, 94 };
            var iop = mass8.Where(x => x > 0).Select(x => x % 10).Distinct();
            foreach (var iopa in iop)
                Console.WriteLine(iopa);

            //LinqBegin36
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin36");
            Console.WriteLine("");
            string[] mass9 = { "NFJGK", "BRTI", "HFG6FG", "GGA", "AJKFL" };
            var uouo = mass9.Select(x => x.Length % 2 == 0 ? x[x.Length - 1] : x[0]);
            foreach (var uouoa in uouo)
                Console.WriteLine(uouoa);

            //LinqBegin38
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin38");
            Console.WriteLine("");
            int[] mass10 = { 3, 6, 2, 5, 1, 4 };
            var ii = mass10.Where((_, i) => (i + 1) % 3 != 0).Select((y, i) => i % 2 == 0 ? y * 2 : y);
            foreach (var iii in ii)
                Console.WriteLine(iii);

            //LinqBegin39
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin39");
            Console.WriteLine("");
            string[] mass11 = { "HAB4T", "MKS4IGT", "5QXW" };
            var bb = mass11.SelectMany(x => x).Where(x => Char.IsDigit(x));
            foreach (var bbk in bb)
                Console.WriteLine(bbk);

            //LinqBegin41
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Begin41");
            Console.WriteLine("");
            var kkk = 3;
            string[] mass12 = { "HAB4T.HMG.QA", "BFX3.7HO", "XTM.PK", "LOMI3.GXT" };
            var tyu = mass12.SelectMany(x => x.Split('.')).Where(x => x.Length == kkk).OrderBy(x => x);
            foreach (var tyua in tyu)
                Console.WriteLine(tyua);


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

            //Что-то 8
            Console.WriteLine("");
            Console.WriteLine("Linq" + " " +
                "Что-то 8");
            Console.WriteLine("");
            string[] AAAAAAA = { "HCAB", "CJLM", "AM", "XZ", "FTH", "HCABI", "CJLM2", "AM3", "XZ4", "FTH5" };
            var result6 = AAAAAAA.OrderByDescending(x => x).Select((x, i) => (i+1) + " - " + x);
            foreach (var rrrr in result6)
                Console.WriteLine(rrrr);

            Console.ReadKey();
        }
    }   
}