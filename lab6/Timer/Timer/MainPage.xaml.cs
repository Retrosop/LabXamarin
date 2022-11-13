using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Timer
{
    public partial class MainPage : ContentPage
    {
        private int seconds = 0;
        private bool isRunning = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Start_Clicked(object sender, EventArgs e)
        {
            isRunning= true;
        }
        private void Stop_Clicked(object sender, EventArgs e)
        {
            isRunning = false;
        }
        private void Reset_Clicked(object sender, EventArgs e)
        {
            isRunning = false;
            seconds = 0;
        }
        private void runTimer()
        {
            int hour = (int) seconds/3600;
            int minutes = (int) (seconds % 3600) / 60;
            int secs = (int)(seconds % 60);
            String time = $"{hour}:{minutes}:{secs}";
        }
    }
}
