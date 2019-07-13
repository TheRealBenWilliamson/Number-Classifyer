using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Number_Classifyer
{
    class Program
    {
        static void Main(string[] args)
        {

            //program asks the user what they want to do: train a network or create a new one
            while (true)
            {
                Console.WriteLine("What would you like to do? \n1) Create a new network \n2) Train an existing network");
                string Input = Console.ReadLine();
                if (Input == "1")
                {
                    //Create a new network
                    Console.WriteLine("What would you like to call the new network?");
                    string Name = Console.ReadLine();

                    List<uint> Dimensions = new List<uint>();
                    //Dimvalue will not be 10 but it just cannot start as zero
                    uint DimValue = 10;
                    int ColNum = 1;
                    while(DimValue != 0)
                    {
                        try
                        {
                            Console.WriteLine("How many nodes would you like in column {0}?", ColNum);
                            DimValue = Convert.ToUInt32(Console.ReadLine());
                            if(DimValue != 0)
                            {
                                Dimensions.Add(DimValue);
                            }                           
                            ColNum++;
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a valid input");
                        }
                    }

                    /*
                     CREATE THE NETWORK HERE
                    */

                    Network GenNetwork = new Network(Name, Dimensions);


                    Console.WriteLine("Your network has been successfully created and saved\nPress <ENTER> to continue");
                    Console.ReadLine();
 
                }
                else if(Input == "2")
                {                   
                    //Train an existing network

                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                    //repeats
                }
            }



        }
    }
}
