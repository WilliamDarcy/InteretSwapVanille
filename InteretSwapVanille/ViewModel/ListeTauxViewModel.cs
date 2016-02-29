using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using InteretSwapVanille.Helpers;
using InteretSwapVanille.Model;
using InteretSwapVanille.Views;

namespace InteretSwapVanille.ViewModel
{
    public class ListeTauxViewModel : ObservableObject
    {
        public RelayCommand CommandButtonOk { get; set; }

        public List<Swap> ListeTaux { get; set; }



        public ListeTauxViewModel(InformationSwap infoSwap)
        {
            ListeTaux = infoSwap.ListeSwap;
            
            CommandButtonOk = new RelayCommand(FermerFenetre);
            if (ListeTaux.Count == 0)
            {
                for (int i = 0; i < infoSwap.DureeSwap; i++)
                {

                    ListeTaux.Add(new Swap() {InformationSwapId = infoSwap.InformationSwapId, TauxAnnuel = 0});
                }
                


        }
            
        }

        private void FermerFenetre(object obj)
        {
            Onclose();
        }

       





    }
}