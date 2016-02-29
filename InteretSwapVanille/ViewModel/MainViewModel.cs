using System.Collections.Generic;
using System.Collections.ObjectModel;
using InteretSwapVanille.Helpers;
using InteretSwapVanille.Model;
using InteretSwapVanille.Services;
using InteretSwapVanille.Views;

namespace InteretSwapVanille.ViewModel
{
    public class MainViewModel : ObservableObject
    {
         public RelayCommand CommandAfficherNouveau { get; set; }
         public RelayCommand CommandAfficherListeTaux { get; set; }
         public RelayCommand CommandSauvegarde { get; set; }

        private IRepositorySwap _repoSwap;
        public ObservableCollection<SwapDiscount> ListeDiscount
        {
            get
            {
                return _listeDiscount;
            }

            set
            {
                _listeDiscount = value;
                OnPropertyChanged();

            }
        }

        private ObservableCollection<SwapDiscount> _listeDiscount;
    
        private readonly InformationSwap _infoSwap;

        public MainViewModel()
        {

            CommandAfficherListeTaux = new RelayCommand(AfficherListeTaux, SwapEstCree);
            CommandAfficherNouveau = new RelayCommand(AfficherNouveau);
            CommandSauvegarde = new RelayCommand(Sauver);
            _infoSwap = new InformationSwap {ListeSwap = new List<Swap>()};

        }
        /// <summary>
        /// Sauvegarde les données d'un swap
        /// </summary>
        /// <param name="obj"></param>
        private void Sauver(object obj)
        {
            using (var context = new SwapContext())
            {
                var repository = new RepositorySwap(context);
                var service = new SwapService(repository);
                service.AjouterSwap(_infoSwap);
            }
        }

        /// <summary>
        /// Autorise l'option Liste si on a déjà crée un nouveau swap
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool SwapEstCree(object obj)
        {
            return _infoSwap.DureeSwap != 0;
        }
        /// <summary>
        /// Afficher la fenêtre comprenant les informations
        /// </summary>
        /// <param name="obj">Non utilisé</param>
        private void AfficherNouveau(object obj)
        {
            var infoDialog = new Information(_infoSwap);
            infoDialog.ShowDialog();
        }

        /// <summary>
        /// Affiche la fenêtre de dialog sur les taux et mettre à jour le résultat
        /// </summary>
        /// <param name="obj">Non utilisé</param>
        private void AfficherListeTaux(object obj)
        {
            var listeDialog = new ListeTaux(_infoSwap);
            listeDialog.Closed += ListeDialog_Closed;
            listeDialog.ShowDialog();
            
           
        }

        private void ListeDialog_Closed(object sender, System.EventArgs e)
        {
            var result = new Discount(_infoSwap.ListeSwap);
            ListeDiscount = new ObservableCollection<SwapDiscount>(result.ObtenirListeDiscount());
        }
    }
}