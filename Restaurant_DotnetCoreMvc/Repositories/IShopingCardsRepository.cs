using System.Linq;

namespace Restaurant_DotnetCoreMvc.Models
{
    public interface IShopingCardsRepository
    {
        IQueryable<ShopingCardItem> ShopingCards { get; }
        Pie AddToShopingCard(int id);
        ShopingCardItem RemoveFromShopingCard(int id);

        int TotalOfShopingCards();
        void ClearCard();


    }
}
