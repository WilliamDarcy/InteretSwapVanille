using System.Collections.Generic;
using InteretSwapVanille.Model;

namespace InteretSwapVanille.Model
{
    public class InformationSwap
    {
  
        public int InformationSwapId { get; set; }
        public string Nom { get; set; }
        public int DureePayement { get; set; }
        public int DureeSwap { get; set; }

        public virtual List<Swap> ListeSwap { get; set; }
    


    }

}