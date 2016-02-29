using System;
using System.Collections.Generic;
using InteretSwapVanille.Model;
using InteretSwapVanille.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Swap> listeSwap = new List<Swap>() {new Swap() {InformationSwap = null, InformationSwapId = 1 , TauxAnnuel = 0.05M} , new Swap() { InformationSwap = null, InformationSwapId = 1, TauxAnnuel = 0.06M} };
            Discount discount = new Discount(listeSwap);
            List<SwapDiscount> listeSwapDiscounts = discount.ObtenirListeDiscount();

            Assert.IsTrue(Math.Abs(listeSwapDiscounts[0].Discount - 0.9523M) < 0.0001M);
            Assert.AreEqual(listeSwapDiscounts[0].Taux, 0.05M);
        }

        [TestMethod]
        public void TestMethod_rhinoMocks()
        {
            var repository = MockRepository.GenerateMock<IRepositorySwap>();

            var swapService = new SwapService(repository);
            var infoSwap = new InformationSwap() {DureeSwap = 1, InformationSwapId = 1};
            
            //Act
            swapService.AjouterSwap(infoSwap);

            //Assert 
            repository.AssertWasCalled(x => x.Ajouter(infoSwap));
        }
    }
}
