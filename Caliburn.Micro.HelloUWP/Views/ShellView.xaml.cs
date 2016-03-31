using System;
using Windows.UI.Xaml;

namespace Caliburn.Micro.HelloUWP.Views
{
    public sealed partial class ShellView
    {
        public ShellView()
        {
            this.InitializeComponent();
        }

        private void OpenNavigationView(object sender, RoutedEventArgs e)
        {
            this.NavigationView.IsPaneOpen = true;
        }
    }
}
