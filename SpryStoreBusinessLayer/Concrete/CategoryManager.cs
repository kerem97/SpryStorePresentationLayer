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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TInsert(Category t)
        {
            if (t.CategoryName != "" && t.CategoryName.Length >= 5 && t.CategoryName.Length <= 20)
            {
                _categoryDal.Insert(t);
            }
            else
            {
                //hata mesajı
            }
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
