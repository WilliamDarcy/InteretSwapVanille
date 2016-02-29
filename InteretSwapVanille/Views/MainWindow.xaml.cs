using System.Windows;
using InteretSwapVanille.Model;
using InteretSwapVanille.ViewModel;

namespace InteretSwapVanille.Views
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           this.DataContext = new MainViewModel();
        }
    }
}
