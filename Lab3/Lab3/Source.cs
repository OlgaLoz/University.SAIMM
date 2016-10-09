using System;

namespace Lab3
{
    public class Source
    {
        private readonly double probability;

        public Source(double probability)
        {
            this.probability = probability;
        }

        public bool IsBlocked { get; set; } = false;

        public bool GenerateRequest()
        {
            var random = new Random();
            double val = random.NextDouble();

            if (val > probability && !IsBlocked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}