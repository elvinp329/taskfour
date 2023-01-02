namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int r1, r2;
            int tmp;
            bool isDifferencedigit = true;
            while (number != 0)
            {

                r1 = number % 10;
                number /= 10;
                tmp = number;

                while (tmp != 0)
                {
                    r2= tmp % 10;
                    tmp /= 10;

                    if (r1 == r2)
                    {
                        Console.WriteLine("Muxtelif reqemli deyil");
                        isDifferencedigit = false;
                        break;
                    }


                }

                if (!isDifferencedigit)
                    break;
            }
                                                          
                            
            if (!isDifferencedigit ) 
            Console.WriteLine("Muxtelif Reqemlidir");
        }
    }
}