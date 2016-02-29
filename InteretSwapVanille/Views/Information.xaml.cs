using System.Windows;
using InteretSwapVanille.Model;
using InteretSwapVanille.ViewModel;

namespace InteretSwapVanille.Views
{
    /// <summary>
    /// Logique d'interaction pour Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public Information(InformationSwap infoSwap )
        {
            InitializeComponent();
            var infoVm = new InfoSwapViewModel(infoSwap);
            DataContext = infoVm;
            infoVm.Close += (sender, args) => { Close(); };
          
        }
    }
}
