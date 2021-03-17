using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            int numEyes;
            Random dice = new Random();

            int si = byte.MaxValue;
            Console.WriteLine(si);

            int simo = 0;

            for (int i = 0; i < 10; i++)
            {
                
                numEyes = dice.Next(2, 54);
                if (numEyes > simo)
                {
                    simo = numEyes;
                }

                Console.WriteLine($"Number {i} is {numEyes} ");
              


            }
            Console.WriteLine($"\n\n\nThe biggest number is : {simo}");


            Random random = new Random();
            byte[] b = new byte[10];
            random.NextBytes(b);

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            


            
            Console.WriteLine("\n\nPlease enter your question?\n ");
            Console.ReadLine();

            Random yesNoMaybe = new Random();
            int answerNum = yesNoMaybe.Next(1, 4);
            

            if (answerNum == 1)
            {
                Console.WriteLine("Yes");
            }
             else if (answerNum == 2)
            {
                Console.WriteLine("Maybe");
            }
            else
            {
                Console.WriteLine("No");
            }




    


            Console.ReadLine();
        }
    }
}
