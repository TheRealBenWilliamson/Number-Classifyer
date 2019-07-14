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
                Console.WriteLine("What would you like to do? \n1) Create a new network \n2) Train an existing network \n3) Test an existing network");
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
                    Console.WriteLine("Which network would you like to train? CURRENTLY JUST PRESS ENTER");
                    Console.ReadLine();


                    //the network below is simply a place holder while i learn how to read CSV files. just call the new network 'Net'
                    List<uint> MockDimensions = new List<uint>() { 2, 2, 2 };
                    Network Net = new Network("Net", MockDimensions);
                    /*
                      FIND AND USE THE CORRECT NETWORK
                    */


                    Console.WriteLine("How many times would you like the program to train");
                    int Times = Convert.ToInt32(Console.ReadLine());
                    for (int Trained = 0; Trained <= Times; Trained++)
                    {
                        Net.Train();
                    }

                }
                else if (Input == "3")
                {
                    //Test an existing network                   
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
