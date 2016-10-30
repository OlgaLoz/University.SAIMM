using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        private int block;
        private int takts = 1000000;
        private int requestOut;

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
            for (int i = 0; i < takts; i++)
            {
                var isSecondChannelProcess = secondChannel.ProcessRequest();
                var isFirstChannelProcess = firstChannel.ProcessRequest();
                var isSourceGenerate = source.GenerateRequest();

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
                    firstChannel.HasRequest = true;
                }

                if (isSourceGenerate && !queue.HasRequest && !firstChannel.HasRequest)
                {
                    firstChannel.HasRequest = true;
                }
                else if (isSourceGenerate && !queue.HasRequest && firstChannel.HasRequest)
                {
                    queue.HasRequest = true;
                }
                else if (isSourceGenerate && queue.HasRequest)
                {
                    source.IsBlocked = true;
                }

                if (source.IsBlocked)
                {
                    block++;
                }

                //unlock source
                if (!queue.HasRequest && source.IsBlocked)
                {
                    source.IsBlocked = false;
                }

            }

            label5.Text = ((double)block/takts).ToString();
            label7.Text = ((double)(takts - requestOut)/takts).ToString();
        }
    }
}
