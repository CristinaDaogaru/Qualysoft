﻿using CheckoutApi.DataAccess.Repositories.Interfaces;

namespace CheckoutApi.DataAccess.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBasketRepository BasketRepository { get; }

        IItemRepository ItemRepository { get; }

        ICustomerRepository CustomerRepository { get; }

        IItemsInBasketRepository ItemsInBasketRepository { get; }

        Task<int> SaveChangesAsync();
    }
}
