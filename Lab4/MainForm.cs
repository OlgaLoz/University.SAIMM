using System;
using System.Windows.Forms;

namespace Lab4
{
    public partial class MainForm : Form
    {
        private int minutesCount = 50000;
        private int accuracy = 7;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int channelsCount = int.Parse(txtChannelsCount.Text);
            int minQueueLength = int.Parse(txtMinQueueLength.Text);
            int maxQueueLength = int.Parse(txtMaxQueueLength.Text);
            int intensity = int.Parse(txtIntensity.Text);
            int serviceTime = int.Parse(txtServiceTime.Text);

            txtCharacteristics.Text = string.Empty;
            
            for (int queueLength = minQueueLength; queueLength <= maxQueueLength; queueLength++)
            {
                var gasStation = new GasStation(minutesCount, queueLength, channelsCount, serviceTime, intensity);
                gasStation.DoWork();
                var characteristics = gasStation.GetSystemCharacteristics();

                txtCharacteristics.Text += $"m = {queueLength} {Environment.NewLine}" +
                                           $"  P(refusal) = {Math.Round(characteristics.RefusalProbability, accuracy)} {Environment.NewLine} " +
                                           $"  L(queue) = {Math.Round(characteristics.AverageQueueLength, accuracy)} {Environment.NewLine} " +
                                           $"  cars(total) = {characteristics.TotalCarsCount} {Environment.NewLine} " +
                                           $"  service time(avg) = {characteristics.AvgServiceTime} {Environment.NewLine} " +
                                           $"{Environment.NewLine}";
            }
        }
    }
}
