

namespace InteretSwapVanille.Model
{
    public class RepositorySwap : IRepositorySwap
    {
        private readonly SwapContext _context;
        public RepositorySwap(SwapContext context)
        {
            _context = context;
        }

        public void Ajouter(InformationSwap nouveauxSwap)
        {
            _context.InformationSwap.Add(nouveauxSwap);
            _context.SaveChanges();
        }
    }
}