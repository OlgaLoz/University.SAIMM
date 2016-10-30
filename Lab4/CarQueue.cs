namespace Lab4
{
    public class CarQueue
    {
        private readonly int queueLength;

        public CarQueue(int queueLength)
        {
            this.queueLength = queueLength;
        }

        public int Count { get; private set; }

        public bool Push()
        {
            if (Count == queueLength)
            {
                return false;
            }

            Count++;
            return true;
        }

        public bool Pop()
        {
            if (Count == 0)
            {
                return false;
            }

            Count--;
            return true;
        }
    }
}
