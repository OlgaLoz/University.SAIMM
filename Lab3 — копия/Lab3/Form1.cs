using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        private int block;
        private int takts = 1000000;
        private int allRequestsCount;
        private int requestOut;

        private int requestsInQueueCount;
        private int allRequestsInQueuetime;
        private int singleRequestsInQueuetime;



        public Lab3()
        {
            InitializeComponent();
        }

        private void SimulateBtn_Click(object sender, EventArgs e)
        {
            var source = new Source(double.Parse(textBox1.Text));
            var firstChannel = new FirstChannel(double.Parse(textBox2.Text));
            var secondChannel = new SecondChannel(double.Parse(textBox3.Text));
            var queue = new Queue();
            block = 0;
            requestOut = 0;
            allRequestsCount = 0;
            requestsInQueueCount = 0;
            allRequestsInQueuetime = 0;
            singleRequestsInQueuetime = 0;

            for (int i = 0; i < takts; i++)
            {
                var isSourceGenerate = source.GenerateRequest();

                var isSecondChannelProcess = secondChannel.ProcessRequest();
                var isFirstChannelProcess = firstChannel.ProcessRequest();


                if (isSourceGenerate)
                {
                    allRequestsCount++;
                }

                if (isFirstChannelProcess && !secondChannel.HasRequest)
                {
                    secondChannel.HasRequest = true;
                }
                else if (isFirstChannelProcess && secondChannel.HasRequest)
                {
                    requestOut++;
                    //сброс
                }

                if (isFirstChannelProcess && queue.HasRequest)
                {
                    queue.HasRequest = false;
                    allRequestsInQueuetime += singleRequestsInQueuetime;
                    singleRequestsInQueuetime = 0;
                    firstChannel.HasRequest = true;
                }

                if (queue.HasRequest)
                {
                    singleRequestsInQueuetime++;
                }

                if (isSourceGenerate && !queue.HasRequest && !firstChannel.HasRequest)
                {
                    firstChannel.HasRequest = true;
                }
                else if (isSourceGenerate && !queue.HasRequest && firstChannel.HasRequest)
                {
                    queue.HasRequest = true;
                    requestsInQueueCount++;
                    singleRequestsInQueuetime++;
                    source.IsBlocked = true;
                }

               /* else if (isSourceGenerate && queue.HasRequest)
                {
                    source.IsBlocked = true;
                }*/



                //unlock source
                if (!queue.HasRequest && source.IsBlocked)
                {
                    source.IsBlocked = false;
                }

                if (source.IsBlocked)
                {
                    block++;
                }
            }

            label5.Text = Math.Round((double)block/takts, 6).ToString();
            label7.Text = Math.Round((double)(allRequestsCount - requestOut)/allRequestsCount, 6).ToString();
            label9.Text = ((double) allRequestsInQueuetime/requestsInQueueCount).ToString();
        }
    }
}
