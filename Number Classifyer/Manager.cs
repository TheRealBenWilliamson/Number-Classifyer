using System;
using System.Collections.Generic;
using System.Text;

namespace Number_Classifyer
{
    class Manager
    {
        //This class will hold any variables or functions that strongly affect the network as a whole. It is a singleton.
        //If they are all in one place then I will be able to experiment with them properly.
        //Eg: The learning rate, The activation function, The range/distribution of random starting weights

        private String NetworkLocation;


        public Manager()
        {
            NetworkLocation = "E:\\_documents\\programming\\projects\\Hand written number classifyer NN\\Networks";
        }
    }
}
