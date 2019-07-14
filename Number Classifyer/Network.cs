using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Number_Classifyer
{
    class Network
    {
        //The Network's main variable is the XML file connected to it that contains the weights of each node within the network
        //The network as a whole can be overseen from here. As this is a class, multiple networks can be generated without interfering with eachother.
        //This will contain functions for generating the structure properly

        //NodeInfo is a 2d array with dimesions of custom length and a height matching the largest number of nodes in any layer. layers with fewer nodes than this dimension will have a zero weight.
        //I will call zero-weight-nodes 'Invisible Nodes'. Nodes with weight are 'Visible Nodes'
        //NodeInfo is Stored as X,Y
        protected Node[,] m_NodeInfo;
        protected Coordinate m_NetworkSize = new Coordinate();
        protected List<uint> m_Dimensions;
        protected string m_Name;
        protected List<int> m_DataWhiteList;
        private Random Rnd = new Random();

        /*
          IMPORTED NETWORK CONSTRUCTOR
        */

        //New Network constructor
        public Network(string p_Name, List<uint> p_Dimensions)
        {
            //INSTANCIATE THE DATA WHITE LIST

            m_Name = p_Name;
            m_Dimensions = p_Dimensions;

            //Finding largest value in Dimensions
            uint Largest = 0;
            for(int Index = 0; Index < m_Dimensions.Count; Index++)
            {
                if(m_Dimensions[Index] > Largest)
                {
                    Largest = m_Dimensions[Index];
                }
            }           

            //Creating an array of Nodes
            m_NodeInfo = new Node[m_Dimensions.Count, Largest];
            NetworkSize.X = (uint)m_Dimensions.Count;
            NetworkSize.Y = Largest;

            Coordinate Position = new Coordinate();
            bool Invisible;
            
            for (int X = 0; X < NetworkSize.X; X++)
            {
                Position.X = (uint)X;
                for (int Y = 0; Y < NetworkSize.Y; Y++)
                {
                    Position.Y = (uint)Y;

                    Invisible = false;
                    //finding if the node is invisible
                    if (Y <= Dimensions[(int)(Position.X)])
                    {
                        Invisible = true;
                    }

                    //the node will generate its own connection weights on initialisation. it can do this as it doesn't actually form any connections, but gives weights to where they should be.
                    Node GenNode = new Node(this, Position, Invisible);
                    m_NodeInfo[X, Y] = GenNode;

                }
            }

            //EXPORT THE NETWORK FILE HERE
            Console.WriteLine("CREATING FILE HERE       PRESS ENTER");
            Console.ReadLine();

        }

        public void Train()
        {
            //picks a random sample of data from the data white list
            int DataIndex = Rnd.Next(0, m_DataWhiteList.Count);
        }

        public double Test()
        {
            Double SuccessRate = 0;
            int Succeeded = 0;

            return SuccessRate;
        }



        public Node[,] NodeInfo
        {
            get
            {
                return m_NodeInfo;
            }
            set
            {
                m_NodeInfo = value;
            }
        }

        public Coordinate NetworkSize
        {
            get
            {
                return m_NetworkSize;
            }
            set
            {
                m_NetworkSize = value;
            }
        }

        public List<uint> Dimensions
        {
            get
            {
                return m_Dimensions;
            }
            set
            {
                m_Dimensions = value;
            }
        }




    }
}
