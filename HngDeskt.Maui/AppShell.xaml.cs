using HngDeskt.Maui.PageModels;

namespace HngDeskt.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new MainPageModel();
        }
    }
}
