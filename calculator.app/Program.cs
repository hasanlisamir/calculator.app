namespace calculator.app;

class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        do
        {

        
        Console.WriteLine("eded 1 i daxil edin");



        double eded1 = double.Parse(Console.ReadLine());

        Console.WriteLine("eded 2 i daxil edin");

        double eded2 = double.Parse(Console.ReadLine());
        Console.WriteLine("1.toplama\n" +
            "2.cixma\n" +
            "3.vurma\n" +
            "4.bolme\n" +
            "0.emeliyyatdan cixis");
        Console.WriteLine("zehmet olmasa secim edin");
        int secim = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (secim)
            {
                case 1:
                    Console.WriteLine(eded1 + eded2);
                    break;

                case 2:
                    Console.WriteLine(eded1 - eded2);
                    break;
                case 3:
                    Console.WriteLine(eded1 * eded2);
                    break;
                case 4:
                    if (eded2 != 0)
                    {

                        Console.WriteLine(eded1 / eded2);
                    }
                    else
                    {
                        Console.WriteLine("0 bolme yoxdur");

                    }
                    break;
                case 0:
                    Console.WriteLine("programdan cixdiniz");
                    flag = false;
                    break;

                default:
                    Console.WriteLine("duzgun secim edin");
                    break;

            }
        
        } while (flag);
    }
}

