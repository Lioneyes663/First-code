using System;

namespace QuadratnoeYravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double x2;
            Console.WriteLine("Введите коэффициенты квадратного уравнения: ax*x+bx+c=k");
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("k=");
            double k = Convert.ToDouble(Console.ReadLine());
            double d = b * b - 4 * a * c;
            double chis1 = (-b + Math.Sqrt(d));
            double chis2 = (-b - Math.Sqrt(d));
            double znam = 2 * a;
            int chis1New;
            int chis2New;
            int znam1New;
            int znam2New;
            int chis1Signs;
            int chis2Signs;
            int znamSigns;
            int oStatok1;
            int oStatok2;
            //int generalSigns1;
            //int generalSigns2;
            int celoe1;
            int celoe2;
            if (d < 0)
            {
                Console.WriteLine("Нет решения");
                return;
            }
            if (b == 0 && c == 0 && k != 0)
            {
                x1 = Math.Sqrt(k / a);
                x2 = -Math.Sqrt(k / a);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
            chis1Signs = chis1.ToString().Split(',', '.')[1].Length; 
            chis2Signs = chis2.ToString().Split(',', '.')[1].Length;
            znamSigns = znam.ToString().Split(',', '.')[1].Length;
            if (chis1Signs == 0)
            {
                chis1New = Convert.ToInt32(chis1) * znamSigns * 10;
                znam1New = Convert.ToInt32(znam) * znamSigns * 10;
                celoe1 = chis1New / znam1New;
                oStatok1 = chis1New % znam1New;
                while (znam1New % 2 == 0)
                {
                    znam1New = znam1New / 2;
                }
                while (znam1New % 5 == 0)
                {
                    znam1New = znam1New / 5;
                }
                if (znam1New == 1)
                    Console.WriteLine($"{x1}");
                else
                    Console.WriteLine($"{celoe1}.{chis1New}/{znam1New}");
            }
            if (chis2Signs == 0)
            {
                chis2New = Convert.ToInt32(chis1) * znamSigns * 10;
                znam2New = Convert.ToInt32(znam) * znamSigns * 10;
                celoe2 = chis2New / znam2New;
                oStatok2 = chis2New % znam2New;
                while (znam2New % 2 == 0)
                {
                    znam2New = znam2New / 2;
                }
                while (znam2New % 5 == 0)
                {
                    znam2New = znam2New / 5;
                }
                if (znam2New == 1)
                    Console.WriteLine($"{x2}");
                else
                    Console.WriteLine($"{celoe2}.{chis2New}/{znam2New}");
            }
            if (znamSigns == 0)
            {
                chis1New = Convert.ToInt32(chis1) * chis1Signs * 10;
                znam1New = Convert.ToInt32(znam) * chis1Signs * 10;
                celoe1 = chis1New / znam1New;
                oStatok1 = chis1New % znam1New;
                while (znam1New % 2 == 0)
                {
                    znam1New = znam1New / 2;
                }
                while (znam1New % 5 == 0)
                {
                    znam1New = znam1New / 5;
                }
                if (znam1New == 1)
                    Console.WriteLine($"{x1}");
                else
                    Console.WriteLine($"{celoe1}.{chis1New}/{znam1New}");
            }
            if (znamSigns == 0)
            {
                chis2New = Convert.ToInt32(chis1) * chis2Signs * 10;
                znam2New = Convert.ToInt32(znam) * chis2Signs * 10;
                celoe2 = chis2New / znam2New;
                oStatok2 = chis2New % znam2New;
                while (znam2New % 2 == 0)
                {
                    znam2New = znam2New / 2;
                }
                while (znam2New % 5 == 0)
                {
                    znam2New = znam2New / 5;
                }
                if (znam2New == 1)
                    Console.WriteLine($"{x2}");
                else
                    Console.WriteLine($"{celoe2}.{chis2New}/{znam2New}");
            }

            /*generalSigns1 = chis1Signs > znamSigns ? chis1Signs : znamSigns;
            generalSigns2 = chis2Signs > znamSigns ? chis2Signs : znamSigns;

            chis1New = Convert.ToInt32(chis1) * generalSigns1 * 10;
            chis2New = Convert.ToInt32(chis2) * generalSigns2 * 10;

            znam1New = Convert.ToInt32(znam) * generalSigns1 * 10;
            znam2New = Convert.ToInt32(znam) * generalSigns2 * 10;

            celoe1 = chis1New / znam1New;
            celoe2 = chis2New / znam2New;

            oStatok1 = chis1New % znam1New;
            oStatok2 = chis2New % znam2New;

            while (znam1New % 2 == 0)
            {
                znam1New = znam1New / 2;
            }
            while (znam1New % 5 == 0)
            {
                znam1New = znam1New / 5;
            }
            while (znam2New % 2 == 0)
            {
                znam2New = znam2New / 2;
            }
            while (znam2New % 5 == 0)
            {
                znam2New = znam2New / 5;
            }
            if (znam1New == 1)
                Console.WriteLine($"{x1}");
            else
                Console.WriteLine($"{celoe1}.{chis1New}/{znam1New}");
            if (znam2New == 1)
                Console.WriteLine($"{x2}");
            else
                Console.WriteLine($"{celoe2}.{chis2New}/{znam2New}");*/
        }
    }
}
