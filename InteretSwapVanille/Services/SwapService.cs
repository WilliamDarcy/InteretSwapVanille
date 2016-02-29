using InteretSwapVanille.Model;

namespace InteretSwapVanille.Services
{
    public class SwapService 
    {
        private readonly IRepositorySwap _repositorySwap;

        public SwapService(IRepositorySwap repo)
        {
            _repositorySwap = repo;
        }

        public void AjouterSwap(InformationSwap nouveauSwap)
        {
            _repositorySwap.Ajouter(nouveauSwap);
        }
    }
}