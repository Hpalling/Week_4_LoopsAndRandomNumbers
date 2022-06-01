using System;

namespace LoopsAndRandomNum.s
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog. küsib kasutajalt sisestada pin,
            //prog. võrdleb sisestatud andmeid arvuga 1234;
            //kui sisestatud pin on 1234, siis kubav "tere tulemast!";
            //kui sestatud on vale, kuvab "vale pin";
            //kasutaja on kolm katset

            int i = 0; //i - iteration


            while (i < 3) 
            {
                Console.WriteLine("Sisetage oma pin-kood");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if(userPin == 1234)
                {
                    Console.WriteLine("tere tulemast");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale pin. { 3 - i } katset on jäänud");
                }
                
                
            }
            
            Console.WriteLine("kena päeva");
        }

    }

}



