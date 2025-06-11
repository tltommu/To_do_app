using To_do_app.Models;
using To_do_app.PageModels;

namespace To_do_app.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}