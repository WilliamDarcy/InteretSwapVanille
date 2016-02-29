namespace InteretSwapVanille.Model
{
    public class Swap
    {
        public int SwapId { get; set; }
        public decimal TauxAnnuel { get; set;}
        
        public int InformationSwapId { get; set; }
        public virtual InformationSwap InformationSwap { get; set; }
    
    }
}