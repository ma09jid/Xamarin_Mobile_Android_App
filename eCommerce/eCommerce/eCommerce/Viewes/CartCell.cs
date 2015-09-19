﻿using Xamarin.Forms;

namespace eCommerce.Viewes
{
    public class CartCell : ViewCell
    {
        public CartCell()
        {
            var cellLayout = new StackLayout();
            var detailsLayout = new StackLayout();
            var priceLayout = new StackLayout(); 

            var nameLabel = new Label();
            var nameContentView = new ContentView();
            var qtyLabel = new Label();
            var qtyContentView = new ContentView();
            var priceLabel = new Label();
            var priceContentView = new ContentView();
            var costLabel = new Label();
            var costContentView = new ContentView();

            nameLabel.Text = "Product Name";
            qtyLabel.Text = "2";
            priceLabel.Text = "Price: $22.50";
            costLabel.Text = "Cost: $45";

            cellLayout.Orientation = StackOrientation.Horizontal;
            cellLayout.Spacing = 0;
            detailsLayout.Spacing = 0;
            priceLayout.Orientation = StackOrientation.Horizontal;
            priceLayout.Spacing = 0;
            qtyLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
            qtyLabel.TextColor = Color.Red;
            qtyLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
            qtyLabel.FontAttributes = FontAttributes.Bold;
            priceLabel.FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
            priceLabel.TextColor = Color.Gray;
            costLabel.FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
            costLabel.TextColor = Color.Gray;
            nameContentView.Padding = new Thickness(5);
            qtyContentView.Padding = new Thickness(10);
            priceContentView.Padding = new Thickness(5);
            costContentView.Padding = new Thickness(5);

            nameContentView.Content = nameLabel;
            qtyContentView.Content = qtyLabel;
            priceContentView.Content = priceLabel;
            costContentView.Content = costLabel;
            cellLayout.Children.Add(qtyContentView);
            cellLayout.Children.Add(detailsLayout);
            detailsLayout.Children.Add(nameContentView);
            detailsLayout.Children.Add(priceLayout);
            priceLayout.Children.Add(priceContentView);
            priceLayout.Children.Add(costContentView);
            View = cellLayout;
        }
    }
}