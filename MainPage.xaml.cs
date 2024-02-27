namespace StateMachine
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int state = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            trafficController();
        }

        private void trafficController()
        {
            if (state == 0)
            {
                countUp();
                if (count == 10)
                {
                    state = 1;
                }
            } else
            {
                countDown();
                if (count == 0)
                {
                    state = 0;
                }
            }
        }

        private void countUp()
        {
                count++;

                if (count == 1)
                    CounterBtn.Text = $"Clicked {count} time";
                else
                    CounterBtn.Text = $"Clicked {count} times";

                SemanticScreenReader.Announce(CounterBtn.Text);
            }
        

        private void countDown()
        {
            count--;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
