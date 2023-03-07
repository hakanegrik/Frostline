using System;
using System.Collections.Generic;
using FrostlineECommerce.App.Business.Abstract;
using FrostlineECommerce.App.DataAccess.Abstract;
using FrostlineECommerce.App.Entitiy.Concrete;

namespace FrostlineECommerce.App.Business.Concrete
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void TAdd(Product product)
        {
            _productRepository.Add(product);
        }

        public void TDelete(Product product)
        {
            _productRepository.Delete(product);
        }

        public List<Product> TGetAll()
        {
            return _productRepository.GetAll();
        }

        public Product TGetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void TUpdate(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
