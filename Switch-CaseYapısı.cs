using System;

namespace program;

    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch(month)
            {
                case 1:
                Console.WriteLine("ocak ayındasınız");
                break;

                case 2:
                Console.WriteLine("şubat ayındasınız");
                break;

                case 4:
                Console.WriteLine("nisan ayındasınız");
                break;

                case 3:
                Console.WriteLine("mart ayındasınız");
                break;

                default : 
                Console.WriteLine("yanlış veri girişi");
                break;

                


            }

        }
    }
