using System;
using System.Collections.Generic;
using InteretSwapVanille.Helpers;
using InteretSwapVanille.Model;

namespace InteretSwapVanille.ViewModel
{
    public class InfoSwapViewModel : ObservableObject
    {
        public  InformationSwap InfoSwap { get; set; }
        public RelayCommand CommandButtonOk { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="infoSwap">Les information du swap</param>
        public InfoSwapViewModel(InformationSwap infoSwap)
        {
            if (infoSwap == null) throw new ArgumentNullException(nameof(infoSwap));
            CommandButtonOk = new RelayCommand(FermerFenetre);
            InfoSwap = infoSwap;
            InfoSwap.ListeSwap = new List<Swap>();
        }

        private void FermerFenetre(object obj)
        {
            
            Onclose();
        }

        public string Nom
        {
            get { return InfoSwap.Nom; }

            set { InfoSwap.Nom = value; OnPropertyChanged();}
        }

        public int Duree
        {
            get { return InfoSwap.DureeSwap; }

            set
            {
                InfoSwap.DureeSwap = value; OnPropertyChanged();
            }
        }


    }
}