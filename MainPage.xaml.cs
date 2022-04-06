using System;
using Xamarin.Forms;

namespace Counter
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void PlusOne(object sender, EventArgs e)
        {
            count++;
            CounterWindow.Text = count.ToString();
            
        }

        private void MinusOne(object sender, EventArgs e)
        {
            count--;
            CounterWindow.Text = count.ToString();
        }

        private void PlusFive(object sender, EventArgs e)
        {
            count = count + 5;
            CounterWindow.Text = count.ToString();
        }

        private void MinusFive(object sender, EventArgs e)
        {
            count = count - 5;
            CounterWindow.Text = count.ToString();
        }

        private void PlusTen(object sender, EventArgs e)
        {
            count = count + 10;
            CounterWindow.Text = count.ToString();
        }

        private void MinusTen(object sender, EventArgs e)
        {
            count = count - 10;
            CounterWindow.Text = count.ToString();
        }
    }
}
