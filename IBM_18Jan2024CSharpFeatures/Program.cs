using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures
{
    internal class Program
    {
        public static void Main()
        {
            int choice = 0;

            do
            {
                Console.Clear();


                Console.WriteLine(  "1.User Defined Method\n2.Properties and Indexers\n3.CTor\n4.Interface\n-1:EXIT\n\n");
                Console.Write("Enter Choice:");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {

                    Console.WriteLine("Invalid option !!!\n\npress any key to continue..." );

                    Console.ReadKey();
                    return;


                }

                Console.Clear();

                if (choice==1)
                {
                    UDMEg.UDMExec();
                    Console.WriteLine( "\n\n\nPress any Key to Continue...");
                    Console.ReadKey();
                }

                if (choice==2)
                {
                    PropIndexEg.Exec();
                    Console.WriteLine( "\n\n\nPress any Key to Continue...");
                    Console.ReadKey();
                }

                if (choice == 3)
                {
                    CtorEg.Exec();
                    Console.WriteLine("\n\n\nPress any Key to Continue...");
                    Console.ReadKey();
                }

                if (choice == 4)
                {
                    InterfaceEg.Exec();
                    Console.WriteLine("\n\n\nPress any Key to Continue...");
                    Console.ReadKey();
                }
            } while (choice!=-1);


            
        }

      
    }

}

