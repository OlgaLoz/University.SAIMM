using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    public class GasStation
    {
        private readonly Random rnd = new Random();

        private readonly int minutesCount;
        private readonly int queueLength;
        private readonly int intensity;
        private readonly CarQueue queue;
        private readonly List<CarChannel> channels;

        private int totalQueueLength;
        private int totalRefusalCount;
        private int totalCarsCount;

        public GasStation(int minutesCount, int queueLength, int channelsCount, int serviceTime, int intensity)
        {
            this.minutesCount = minutesCount;
            this.queueLength = queueLength;
            this.intensity = intensity;
            queue = new CarQueue(queueLength);
            channels = new List<CarChannel>();
            for (int i = 0; i < channelsCount; i++)
            {
                channels.Add(new CarChannel(serviceTime));
            }
        }

        public void DoWork()
        {
            var arrivedCars = GetArrivedCarsPositions();

            for (int i = 0; i < minutesCount * 60; i++)
            {
                int arrivedCarsCount = arrivedCars[i] ? 1 : 0;
                
                totalCarsCount += arrivedCarsCount;

                channels.ForEach(channel =>
                {
                    if (!channel.IsFree)
                    {
                        return;
                    }

                    if (queue.Pop())
                    {
                        channel.SetCarForProcessing();
                    }
                    else
                    {
                        if (arrivedCarsCount == 0)
                        {
                            return;
                        }

                        arrivedCarsCount--;
                        channel.SetCarForProcessing();
                    }
                });

                for (int j = 0; j < arrivedCarsCount; j++)
                {
                    totalRefusalCount += queue.Push() ? 0 : 1;
                }

                totalQueueLength += queue.Count;
                
                channels.ForEach(channel => channel.DoIteration());
            }

            var totalCarsProcessed = channels.Sum(car => car.CarsProcessed);
            var income = totalCarsProcessed * 5;
            var hoursCount = (double)minutesCount / 60;
            var cost = hoursCount * 20 * queueLength;

            var profit = (income - cost) / hoursCount;
        }

        public SystemCharacteristics GetSystemCharacteristics()
        {
            return new SystemCharacteristics
            {
                TotalCarsCount = totalCarsCount,
                AvgServiceTime = channels[0].AvgServiceTime,

                AverageQueueLength = (double) totalQueueLength/(minutesCount * 60),
                RefusalProbability = (double) totalRefusalCount/totalCarsCount
            };
        }

        private bool[] GetArrivedCarsPositions()
        {
            var result = new bool[minutesCount * 60];

            for (int i = 0; i < minutesCount * 60; i += 60)
            {
                result[i + GetCurrentArrivedCarPosition()] = true;
            }

            return result;
        }

        private int GetCurrentArrivedCarPosition()
        {
            return (int)Math.Round(-1.0 / intensity * Math.Log(1 - rnd.NextDouble()) * 60) % 60;
        }
    }
}
