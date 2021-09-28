using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2
{
    class Program
    {

       static void Main(string[] args)
        {
            bool b1 = true;Console.WriteLine(b1);
            bool b2 = false; Console.WriteLine(b2);
            sbyte sb = 12; Console.WriteLine(sb);
            byte by = 24; Console.WriteLine(by);
            short sh = 12000; Console.WriteLine(sh);
            ushort ush = 65000; Console.WriteLine(ush);
            int it = 127000000; Console.WriteLine(it);
            uint uit = 0; Console.WriteLine(uit);
            long l1 = 28762683252; Console.WriteLine(l1);
            ulong l2 = 2424; Console.WriteLine(l2);
            char ch1 = 'a'; Console.WriteLine(ch1);
            float f1 = 125.1F; Console.WriteLine(f1);
            double d1 = 338.25; Console.WriteLine(d1);
            decimal dec1 = 1.01m; Console.WriteLine(dec1);
            string str1 = "hello"; Console.WriteLine(str1);
            dynamic dyn = 1; Console.WriteLine(dyn);
            object obj = 1; Console.WriteLine(obj);
            byte a = 4;    
            ushort b = a;//неявное преобразование 
            int f = 4;
            int h = 6;
            byte y = (byte)(f + h);// явное преобразование 



            //convert
            double MyNum = 250.13;
            try 
            {
                int MyNewNum = System.Convert.ToInt32(MyNum);
            }
            catch (System.OverflowException)
            {
                System.Console.WriteLine("Overflow it double to int conversion");
            }

            string StrNum = System.Convert.ToString(MyNum);


            //упаковка и распаковка значимых типов 
            Int32 box = 5;
            Object o = box;//упаковка box, o ссылается на упакованный объект
            byte m = (byte)(int)o;//распаковка, а после приведение типа 

            //неявно типизированная переменная
            var massiv = new[] { 2, 3, 4, 5, 6 };
            Console.Write(massiv.GetType());Console.WriteLine();

            //nullable
            int? xn = null;

            var x13 = 2;
            x13 = 15;


            string strr1 = "Hello";
            string strr2 = "World";
            string strr3 = "!";
            string empty = "";
            string substr = "privet";
            string rndm = "poka";
            Console.WriteLine(strr1 + strr2 + strr3);
            Console.WriteLine(strr1==strr2);
            empty = String.Copy(strr1);Console.WriteLine("copied: " + empty);
            rndm = rndm.Insert(4, substr); Console.WriteLine("added substr: " + rndm);
            Console.WriteLine(rndm.Substring(4) + "-this is substring");
            Console.WriteLine(rndm.Remove(4) + "-substring deleted");
            string splitstr1 = "split me pls";
            string[] words = splitstr1.Split(' ');
            foreach(string i in words)
            {
                Console.WriteLine("words: " + i);
            }


            string Name = "Vladislav";
            string  FavColor = "Purple";
            Console.WriteLine($"Имя: {Name} Любимый цвет: {FavColor}");//Интерполяция строк


            string NULLSTR = null;
            string emptystr = "";
            bool Answer1 = String.IsNullOrEmpty(NULLSTR);Console.WriteLine(Answer1);
            bool Answer2 = String.IsNullOrEmpty(emptystr);Console.WriteLine(Answer2);
            Console.WriteLine("adfsdf:" + NULLSTR + emptystr + "ничего нет...");


            //массивы
            int[,] ArrInt = new int[9, 9];
            Random Rand = new Random();
            Console.WriteLine("=========================================================================================================");
            Console.WriteLine("Int array:");
            for(int i =0;i<Math.Sqrt(ArrInt.Length);i++)
            {
                for(int j=0;j<Math.Sqrt(ArrInt.Length);j++)
                {
                    ArrInt[i, j] = Rand.Next(0,82);
                    Console.Write($"{ArrInt[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=========================================================================================================");

            string[] ArrString = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.WriteLine("=========================================================================================================");
            Console.WriteLine("String array:");
            foreach(string x in ArrString)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\nArray length:" + ArrString.Length);
            Console.WriteLine("Choose the position: ");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Then enter the text: ");
            string TextToSwitch = Console.ReadLine();
            for (int i = 0; i < ArrString.Length; i++)
            {
                if (position == i)
                {
                    ArrString[i] = TextToSwitch;
                    break;
                }
            }
            Console.WriteLine("New String Array:");
            foreach (string x in ArrString)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("=========================================================================================================");

            //jagged array
            int[][] ArrJagged = new int[3][];
            ArrJagged[0] = new int[2];
            ArrJagged[1] = new int[3];
            ArrJagged[2] = new int[4];
            Console.WriteLine("Lets start to fill your array with random value elements... \n");
            Console.WriteLine("Choose minimal value");int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Then choose max value");int max = Convert.ToInt32(Console.ReadLine());
            Random RandJagged = new Random();
            
            for(int i = 0;i<2;i++)
            {
                ArrJagged[0][i] = RandJagged.Next(min, max + 1);
            }
            for (int i = 0; i < 3; i++)
            {
                ArrJagged[1][i] = RandJagged.Next(min, max + 1);
            }
            for (int i = 0; i < 4; i++)
            {
                ArrJagged[2][i] = RandJagged.Next(min, max + 1);
            }


            foreach (int[] z in ArrJagged)
            {
                foreach(int x in z)
                {
                    Console.Write("\t" + x);
                }
                Console.WriteLine();
            }

            // неявно типизированные переменные для хранения массива и строки
            var ArrVar = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var VarString = "this is string";


            //кортежи
            ValueTuple<int, string, char, string, ulong> RandomValueTuple = (25, "HELLO THERE", 'g', "dafk slgk s", 0XFF);
            (string Name, string fName, int age, int score) student = ("Vladislav", "Gud", 19, 450);
            Console.WriteLine(student);
            Console.WriteLine($"{student.Name} {student.age.ToString()} {student.score.ToString()}");
            (string, int) City = ("Minsk", 2021);
            Console.WriteLine(City.Item1);
            ValueTuple<int, int> Coords1 = (5, 10);
            ValueTuple<int, int> Coords2 = (5, 10);
            Console.WriteLine(Coords1 == Coords2);
            Console.WriteLine(Coords1 != Coords2);

            main("hello",new int[] {1,2,3,4,5,6,7,8 });

            int maxnum = int.MaxValue;
            Console.WriteLine(unchecked(maxnum + 10));
            Console.WriteLine(checked(maxnum+10));

            Console.ReadKey();
        }
        static void main(string str, int[] a)
        {
            ValueTuple<int, int, int, string> result;
            int Max = 0, Min = 99999, Sum = 0;
            string FirstLetter = "";

            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>Max)
                {
                    Max = a[i];
                }
            }
            for(int i=0;i<a.Length;i++)
            {
                Sum += a[i];
            }

            for(int i = 0;i<a.Length;i++)
            {
                if (a[i] < Min)
                {
                    Min = a[i];
                }
            }

            FirstLetter = str.Substring(0, 1);

            result.Item1 = Max;
            result.Item2 = Min;
            result.Item3 = Sum;
            result.Item4 = FirstLetter;

            Console.WriteLine(result);
        }
    }
}
