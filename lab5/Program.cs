namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -4;
            double result = (a > 0 ? Math.Sqrt(a) : double.NaN);
            Console.WriteLine(result);
        }

        static void InputExample()
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                while (n-- > 0)
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.WriteLine("Niepoprawny format");
            }
        }

        static void OutParameterExample()
        {
            //int r = 0;
            //Add2(1, 4, out r);
            //Console.WriteLine(r);
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Niepoprawny format danych, wpisz liczbę.");
            }
            Console.WriteLine(input * input);
        }

        static void Add2(int x, int y, out int result)
        {
            result = x + y;
        }

        static void ArrayFuncExample()
        {
            int[] a = { 1, 2, 3 };
            //Fill(a, 5);
            Console.Write(SumArr(a));
            Console.WriteLine(Sum(a));
        }

        static void SwapExample()
        {
            int x = 5;
            int y = 10;
            Swap(ref x, ref y);
            int d = 7;
            Console.WriteLine($"x = {x}, y = {y}");
            Swap(ref y, ref d);
            Console.WriteLine($"y = {y}, d = {d}");
        }

        static double Add(double x = 0, double y = 0)
        {
            double sum = x + y;
            return sum;
        }

        static bool IsEven(int x)
        {
            //if(x % 2 == 0) return true;
            //return false;
            return x % 2 == 0;
        }

        static void PrintLnOnlyPositive(double x)
        {
            if(x < 0)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(x);
        }

        static void Stars()
        {
            Console.WriteLine("********");
            Console.WriteLine("********");
        }

        static void PrintStarsWithParam(int n = 1) //n to parametr z wartością domyślną
        {
            /*
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("*****");
            }
            */
            while(n-- > 0)
            {
                Console.WriteLine("***");
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Fill(int[] arr, int value)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }

        static double SumArr(int[] arr)
        {
            double sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static int Sum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}