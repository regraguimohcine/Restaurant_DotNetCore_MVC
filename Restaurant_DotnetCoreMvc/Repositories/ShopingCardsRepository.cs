using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Restaurant_DotnetCoreMvc.Models
{
    public class ShopingCardsRepository : IShopingCardsRepository
    {
        private readonly MyDbContext _context;
        public ShopingCardsRepository(MyDbContext dbContext)
        {
            _context=dbContext;
        }
        public  IQueryable<ShopingCardItem> ShopingCards
        {
            get 
            {
                return _context.ShopingCards.Include(x=>x.Pie);
            }
        }

        public Pie AddToShopingCard(int id)
        {
            var SelectedPie = _context.Pies.SingleOrDefault(x => x.Id == id);
            if (SelectedPie == null)
                return null;

            var ShopingCard = new ShopingCardItem();
            ShopingCard.Pie = SelectedPie;
            ShopingCard.ShopingCardId = id.ToString();

            _context.ShopingCards.Add(ShopingCard);
            _context.SaveChanges();
            return SelectedPie;
        }

        public void ClearCard()
        {
            _context.ShopingCards.RemoveRange(_context.ShopingCards);
            _context.SaveChanges();
        }

        public ShopingCardItem RemoveFromShopingCard(int id)
        {
            var SelectedCard = _context.ShopingCards.SingleOrDefault(x => x.ShopingCardItemId == id);
            if (SelectedCard == null)
                return null;

            _context.ShopingCards.Remove(SelectedCard);
            _context.SaveChanges();

            return SelectedCard;
        }

        public int TotalOfShopingCards()
        {
            return _context.ShopingCards.Count();
        }
    }
}
