using HngDeskt.Maui.PageModels;

namespace HngDeskt.Maui.Pages;

public partial class KryptorPage : ContentPage
{
    public KryptorPage(KryptorPageModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }
}