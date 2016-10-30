using System;

namespace Lab4
{
    public class CarChannel
    {
        private readonly Random rnd = new Random();

        private readonly int serviceTime;
        private int currentServiceTime;
        private int currentTimeInChannel;

        private int tt1;
        private int tt2;

        public int CarsProcessed;

        public double AvgServiceTime => (double) tt1/(tt2 != 0 ? tt2 : 1);

        public CarChannel(int serviceTime)
        {
            this.serviceTime = serviceTime;
        }

        public bool IsFree { get; private set; } = true;

        public void DoIteration()
        {
            if (IsFree)
            {
                return;
            }

            if (currentTimeInChannel == currentServiceTime)
            {
                IsFree = true;
                currentTimeInChannel = 0;
                CarsProcessed++;
            }
            else
            {
                currentTimeInChannel++;
            }
        }

        public void SetCarForProcessing()
        {
            IsFree = false;
            currentServiceTime = GetCurrentServiceTime();

            tt1 += currentServiceTime;
            tt2++;
        }

        private int GetCurrentServiceTime()
        {
            return (int)Math.Round(-serviceTime * Math.Log(1 - rnd.NextDouble()) * 60);
        }
    }
}
