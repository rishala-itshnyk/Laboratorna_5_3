using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            double zp, zk, r;
            int n;
            Console.Write("zp = ");
            zp = Convert.ToDouble(Console.ReadLine());
            Console.Write("zk = ");
            zk = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            double dz = (zk - zp) / n;
            double z = zp;
            while (z <= zk)
            {
                r = k(Math.Pow(z, 2) + 1) - k(Math.Pow(z, 2) - 1) + 2 * k(z);
                Console.WriteLine($"{z} {r}");
                z += dz;
            }
        }
        
        public static double k(double x)
        {
            if (Math.Abs(x) >= 1)
                return (Math.Exp(x) + Math.Sin(x)) / (Math.Pow(Math.Cos(x), 2) + 1);
            else
            {
                double S = 0;
                int i = 0;
                double a = 1;
                S = a;
                do
                {
                    i++;
                    double R = x / i;
                    a *= R;
                    S += a;
                } while (i < 5);

                double S1 = (1 / Math.Exp(x) * S);
                return S1;
            }
        }
    }
}