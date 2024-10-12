using CommunityToolkit.Maui.Alerts;

namespace MauiApp1.Screens
{
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        // Mark the method as async to use await inside
        private async void SubmitForm(object sender, EventArgs e)
        {
            string getusername = username.Text;

            // Check if selectedClass is not null before calling ToString
            if (selectedClass.SelectedItem != null)
            {
                string studentclass = selectedClass.SelectedItem.ToString();

                // Show the toast with the selected class
                var toast = Toast.Make(studentclass, CommunityToolkit.Maui.Core.ToastDuration.Short);
                await toast.Show(); // Await the toast to show
            }
            else
            {
                // Handle case where no class is selected
                var toast = Toast.Make("No class selected", CommunityToolkit.Maui.Core.ToastDuration.Short);
                await toast.Show();
            }

            // Handle the username input
            if (string.IsNullOrWhiteSpace(getusername))
            {
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
