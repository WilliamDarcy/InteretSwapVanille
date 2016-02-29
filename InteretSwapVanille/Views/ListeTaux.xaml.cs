using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using InteretSwapVanille.Model;
using InteretSwapVanille.ViewModel;

namespace InteretSwapVanille.Views
{
    /// <summary>
    /// Logique d'interaction pour ListeTaux.xaml
    /// </summary>
    public partial class ListeTaux : Window
    {
        public ListeTaux(InformationSwap infoSwap)
        {
            InitializeComponent();
            var listeVm = new ListeTauxViewModel(infoSwap);
            this.DataContext = listeVm;
            listeVm.Close += (sender, args) => { this.Close(); };

        }
    }
}
