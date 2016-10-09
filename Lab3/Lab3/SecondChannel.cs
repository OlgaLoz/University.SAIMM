using System;

namespace Lab3
{
    public class SecondChannel
    {
        private readonly double probability;

        public SecondChannel(double probability)
        {
            this.probability = probability;
        }

        public bool HasRequest { get; set; } = false;

        public bool ProcessRequest()
        {
            var random = new Random();
            double val = random.NextDouble();

            if (val > probability && HasRequest)
            {
                HasRequest = false;
                return true;
            }
            else if (val < probability && HasRequest)
            {
                
            }
            else if(val > probability && !HasRequest)
            {
            }
            else if(val < probability && !HasRequest)
            {
                
            }
            return false;
        }
    }
}