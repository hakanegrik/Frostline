using System;
using System.Collections.Generic;
using FrostlineECommerce.App.Business.Abstract;
using FrostlineECommerce.App.DataAccess.Abstract;
using FrostlineECommerce.App.Entitiy.Concrete;

namespace FrostlineECommerce.App.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void TAdd(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void TDelete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public List<Category> TGetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void TUpdate(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
