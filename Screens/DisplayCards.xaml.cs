using MauiApp1.Models;
using System.Collections.ObjectModel;

namespace MauiApp1.Screens
{
    public partial class DisplayCards : ContentPage
    {
        public ObservableCollection<Product> Products { get; set; }

        public DisplayCards()
        {
            InitializeComponent();

            // Initialize the Products collection
            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Product 1", Description = "Description for product 1", Image = ImageSource.FromResource("MauiApp1.Resources.product1.jpg") },
                new Product { Name = "Product 2", Description = "Description for product 2", Image = ImageSource.FromResource("MauiApp1.Resources.product2.jpg") },
                new Product { Name = "Product 3", Description = "Description for product 3", Image = ImageSource.FromResource("MauiApp1.Resources.product3.jpg") },
                // Add more products as needed
            };

            // Set the BindingContext to this page to bind the Products collection
            BindingContext = this;
        }
    }
}
