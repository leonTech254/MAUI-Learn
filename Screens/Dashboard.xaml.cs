using CommunityToolkit.Maui.Alerts;
using System.Collections.ObjectModel;

namespace MauiApp1.Screens
{
    public partial class Dashboard : ContentPage
    {
        public ObservableCollection<string> ClassList { get; set; }

        public Dashboard()
        {
            InitializeComponent();
            ClassList = new ObservableCollection<string>
            {
                "class 1",
                "class 2",
                "class 3",
                "class 5B"
            };
            BindingContext = this; // Set BindingContext for data binding in XAML
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
