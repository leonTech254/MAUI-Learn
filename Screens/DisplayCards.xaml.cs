using CommunityToolkit.Maui.Alerts;
using MauiApp1.Models; // Make sure this namespace matches your model's namespace
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MauiApp1.Screens
{
    public partial class DisplayCards : ContentPage, INotifyPropertyChanged
    {
        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get => products;
            set
            {
                products = value;
                OnPropertyChanged(); // Notify UI of change
            }
        }

        private bool isLoading;
        public bool IsLoading
        {
            get => isLoading;
            set
            {
                isLoading = value;
                OnPropertyChanged();
            }
        }

        public DisplayCards()
        {
            InitializeComponent();

            // Initialize the Products collection
           

            // Set the BindingContext to this page to bind the Products collection
            BindingContext = this;

            // Simulate loading
          LoadProducts();
        }

        private async  void LoadProducts()
        {
            IsLoading = true;
            await Task.Delay(2000); // Simulate loading delay
            IsLoading = false;
            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Product 1", Description = "Description for product 1", Image = ImageSource.FromResource("MauiApp1.Resources.product1.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                // Add more products as needed
            };
            BindingContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Event handler for item selection
        private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected item
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as Product;

            if (selectedProduct != null)
            {
                // Handle the selected product
                //DisplayAlert("Product Selected", $"You selected: {selectedProduct.Name}", "OK");
                var toast = Toast.Make(selectedProduct.Name, CommunityToolkit.Maui.Core.ToastDuration.Short);
                toast.Show();
            
            }
        }
    }
}
