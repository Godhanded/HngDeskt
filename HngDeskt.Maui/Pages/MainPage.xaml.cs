using HngDeskt.Maui.PageModels;

namespace HngDeskt.Maui.Pages
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
