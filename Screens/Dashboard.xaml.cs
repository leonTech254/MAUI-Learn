namespace MauiApp1.Screens
{
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void SubmitForm(object sender, EventArgs e)
        {
            string getusername = username.Text;

            if (string.IsNullOrWhiteSpace(getusername)) { 
                usernameShow.Text = "Enter Username";
                usernameShow.TextColor = Colors.Red;
            }
            else
            {
                usernameShow.Text = "Hello " + getusername;
                usernameShow.TextColor = Colors.Green;
            }
        }
    }
}
