using SpryStoreBusinessLayer.Abstract;
using SpryStoreDataAccessLayer.Abstract;
using SpryStoreEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryStoreBusinessLayer.Concrete
{
    public class AdressManager : IAdressService
    {
        private readonly IAdressDal _adressDal;

        public AdressManager(IAdressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public void TDelete(Adress t)
        {
            _adressDal.Delete(t);
        }

        public Adress TGetByID(int id)
        {
            return _adressDal.GetByID(id);
        }

        public List<Adress> TGetList()
        {
            return _adressDal.GetList();
        }

        public void TInsert(Adress t)
        {
            _adressDal.Insert(t);
        }

        public void TUpdate(Adress t)
        {
            _adressDal.Update(t);
        }
    }
}
