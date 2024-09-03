namespace MorangoMania
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var mainLayout = new StackLayout
            {
                Padding = new Thickness(30),
                Spacing = 20
            
            };
            var headerLayout = new StackLayout
            {
            
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center           
            
            };
            var logo = new Image
            {
                Source = "MorangoMania.png",
                WidthRequest = 50,
                HeightRequest = 50,            
            };
            var title = new Label
            {
                Text = "Morango Mania",
                FontSize = 24,
                VerticalOptions = LayoutOptions.Center,
                Margin = new Thickness(10,0, 0, 0)            
            };
            headerLayout.Children.Add(logo);
            headerLayout.Children.Add(title);
            var searchBar = new SearchBar
            {
                Placeholder = "Buscar Produtos",
                HorizontalOptions = LayoutOptions.FillAndExpand
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            var loginButton = new Button
            {
                Text = "Login",
                BackgroundColor = Colors.Red,
                TextColor = Colors.White,
                FontSize= 18,
                CornerRadius = 10,
                HorizontalOptions = LayoutOptions.FillAndExpand       
            };
            var registerButton = new Button
            {
                Text = "Registro",
                BackgroundColor = Colors.Red,
                TextColor = Colors.White,
                FontSize= 18,
                CornerRadius = 10,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            mainLayout.Children.Add(loginButton);
            mainLayout.Children.Add(registerButton);
            mainLayout.Children.Add(headerLayout);
            mainLayout.Children.Add(searchBar);

            Content = mainLayout;
        
        
        
        }
    }

}
