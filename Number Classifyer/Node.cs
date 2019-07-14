using System;
using System.Collections.Generic;
using System.Text;

namespace Number_Classifyer
{
    class Node
    {

        //Each node only knows the weights of the connections to the layer infront of itself
        private Network m_Parent;
        private List<Double> m_Weights;
        private Coordinate m_Position;
        private bool m_Invisible;

        public Node(Network p_Parent, Coordinate p_Position, bool p_Invisible)
        {
            List<Double> m_Weights = new List<Double>();
            m_Parent = p_Parent;
            m_Position = p_Position;
            m_Invisible = p_Invisible;

            //Assigning a random weight to all Visible Node connections infront of this node           
            Random Rnd = new Random();
            Double WeightCandidate;

            //If this layer is the last then all connections the weights are all 1, 0 or null? i actually have no idea what is appropriate here
            //CLUELESS!

            //Currently the final layer has zero weights as if the next layer is made of invisible nodes.
            for (int Y = 0; Y < m_Parent.NetworkSize.Y; Y++)
            {
                WeightCandidate = 0;

                //the try will fail if this node is in the final layer as the index of Dimensions is undefined. Because of this, we will assign 
                try
                {
                    //This is a way to see how far down the maximum amount of nodes in the layer is. This is so that we can determine if a node is visible or not.
                    if (Y <= m_Parent.Dimensions[(int)(m_Position.X + 1)])
                    {
                        //the loop is to make sure that the weight is never zero, even by chance.
                        while (WeightCandidate == 0)
                        {
                            WeightCandidate = Rnd.NextDouble();
                        }
                    }
                }
                catch
                {

                }               

                m_Weights.Add(WeightCandidate);
                //as there are no gaps in visible nodes, all invisible node connections will apear as many zeros at the end of the Weights list. all weights lists are same length as the Network height

            }


        }


        public Network Parent
        {
            get
            {
                return m_Parent;
            }
            set
            {
                m_Parent = value;
            }
        }

        public List<Double> Weights
        {
            get
            {
                return m_Weights;
            }
            set
            {
                m_Weights = value;
            }
        }

        public Coordinate Position
        {
            get
            {
                return m_Position;
            }
            set
            {
                m_Position = value;
            }
        }

        public bool Invisible
        {
            get
            {
                return m_Invisible;
            }
            set
            {
                m_Invisible = value;
            }
        }



    }
}
