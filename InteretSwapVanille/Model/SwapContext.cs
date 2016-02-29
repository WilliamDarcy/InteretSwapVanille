using System.Data.Entity;

namespace InteretSwapVanille.Model
{
    public class SwapContext : DbContext
    {
        public DbSet<InformationSwap> InformationSwap { get; set; }
        public DbSet<Swap> Swap { get; set; }
    }
}