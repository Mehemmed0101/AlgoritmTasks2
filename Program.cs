namespace AlgoritmTasks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yas aylarla
            //int n = int.Parse(Console.ReadLine());
            //if (n>=1 && n<=1188)
            //{
            //    int il = n / 12;
            //    int ay = n % 12;
            //    Console.WriteLine($"{n} ay:{il} il ve {ay} ay");

            //}
            //else
            //{
            //    Console.WriteLine("1-1188 intervalinda olmalidir");
            //}
            #endregion
            #region Sifirlarin sayi
            int n = int.Parse(Console.ReadLine());
            int zeroCount = 0;
            int tmp = n;

            while (tmp != 0)
            {
                if (tmp%10== 0) zeroCount++;
                tmp/= 10;
            }
            Console.WriteLine($"{n}-deki sifirlarin sayi={zeroCount}");
            #endregion
            #region Yerdeyisme
            //decimal n = decimal.Parse(Console.ReadLine());
            //int real = (int)n;
            //decimal kesr = n - real;
            //decimal x = (real / 1000M);
            //decimal reverse = x + kesr * 1000;

            //Console.WriteLine($"{reverse}");
            #endregion
        }
    }
}