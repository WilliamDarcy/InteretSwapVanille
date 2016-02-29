using System.Collections.Generic;
using System.Linq;
using InteretSwapVanille.Model;

namespace InteretSwapVanille.Services
{
    public class Discount
    {
        private readonly List<Swap> _listeSwap;
         
        public Discount(List<Swap> listeSwap)
        {
            _listeSwap = listeSwap;
        }

        public List<SwapDiscount> ObtenirListeDiscount()
        {
            List<SwapDiscount> listeSwapDiscount = _listeSwap.Select(swap => new SwapDiscount() {Discount = CalculDiscount(swap.TauxAnnuel), Taux = swap.TauxAnnuel}).ToList();
            return listeSwapDiscount;
        }

        private decimal CalculDiscount(decimal taux)
        {
            return 1/(1 + taux);
        }
    }
}