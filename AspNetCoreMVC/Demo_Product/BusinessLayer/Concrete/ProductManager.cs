using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {/*NOT IProductDAL Yanı genek ekleme silme güncelleme vb işlemlerin interface tutuldu.*/
        IProductDAL _productDAL;//Bu eklendikten sonra cuscoret eklenmeli ctor gibi
        //Peki Nasıl Oluşturulacak Asağıdaki ctor üste değişkeni yazdıktan sonra
        //ProductManager'in üstüne gelip ctrl+nokta ile; generate cunstruct a tıkla değişkeni seç

        //Manager çağırmada yeni ProductDal Oluşturulmalı(New EFProductDAL() gibi)
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }
        public void TDelete(Product t)
        {
            _productDAL.Delete(t);
        }

        public Product TGetById(int id)
        {
           return _productDAL.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _productDAL.GetAll();
        }

        public void TInsert(Product t)
        {
            _productDAL.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDAL.Update(t);
        }
    }
}
