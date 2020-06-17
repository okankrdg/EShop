using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public  class BasketService : IBasketService
    {
        private readonly IAsyncRepository<Basket> _basketRepository;

        public BasketService(IAsyncRepository<Basket> basketRepository)
        {
            _basketRepository = basketRepository;
        }
        public async Task AddItemToBasket(int basketId, int productId, decimal price, int quantity = 1)
        {
            var basket = await _basketRepository
                .FirstAsync(new BasketWithItemsSpecification(basketId));
            var basketItem = basket.Items.FirstOrDefault(x => x.ProductId == productId);
            if (basketItem == null)
            {
                basket.Items.Add(new BasketItem { ProductId = productId, Quantity = quantity, UnitPrice = price });
            }
            else
            {
                basketItem.Quantity += quantity;
            }
            await _basketRepository.UpdateAsync(basket);
        }

        public async Task DeleteBasketAsync(int basketId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetBasketItemCountAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task SetQuantities(int basketId, Dictionary<string, int> quantities)
        {
            throw new NotImplementedException();
        }

        public async Task TransferBasketAsync(string anonymousId, string userName)
        {
            throw new NotImplementedException();
        }
    }
}
