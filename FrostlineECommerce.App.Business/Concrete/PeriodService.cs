using System;
using System.Collections.Generic;
using FrostlineECommerce.App.Business.Abstract;
using FrostlineECommerce.App.DataAccess.Abstract;
using FrostlineECommerce.App.Entitiy.Concrete;

namespace FrostlineECommerce.App.Business.Concrete
{
    public class PeriodService : IPeriodService
    {
        IPeriodRepository _periodRepository;

        public PeriodService(IPeriodRepository periodRepository)
        {
            _periodRepository = periodRepository;
        }

        public void TAdd(Period period)
        {
            _periodRepository.Add(period);
        }

        public void TDelete(Period period)
        {
            _periodRepository.Delete(period);
        }

        public List<Period> TGetAll()
        {
            return _periodRepository.GetAll();
        }

        public Period TGetById(int id)
        {
            return _periodRepository.GetById(id);
        }

        public void TUpdate(Period period)
        {
            _periodRepository.Update(period);
        }
    }
}
