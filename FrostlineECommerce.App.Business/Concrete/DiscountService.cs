using System;
using System.Collections.Generic;
using FrostlineECommerce.App.Business.Abstract;
using FrostlineECommerce.App.DataAccess.Abstract;
using FrostlineECommerce.App.Entitiy.Concrete;

namespace FrostlineECommerce.App.Business.Concrete
{
    public class DiscountService : IDiscountService
    {
        IDiscountRepository _discountRepository;

        public DiscountService(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }
        public void TAdd(Discount discount)
        {
            _discountRepository.Add(discount);
        }

        public void TDelete(Discount discount)
        {
            _discountRepository.Delete(discount);
        }

        public List<Discount> TGetAll()
        {
            return _discountRepository.GetAll();
        }

        public Discount TGetById(int id)
        {
            return _discountRepository.GetById(id);
        }

        public void TUpdate(Discount discount)
        {
            _discountRepository.Update(discount);
        }
    }
}
