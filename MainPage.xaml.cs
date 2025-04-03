namespace Domek_w_górach
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
     
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

           
                CounterBtn.Text = $" {count} polubień ";
               
            
            
        }
        private void OnCounterClicked1(object sender, EventArgs e)
        {
            count++;


            CounterBtn1.Text = $" {count} usunieto polubienie ";
            



        }
    }

}
