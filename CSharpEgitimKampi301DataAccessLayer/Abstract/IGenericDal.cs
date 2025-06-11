using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301DataAccessLayer.Abstract
{
    //Burada bütün entityler için kullanılan CRUD işlemlerini tanımlıyoruz.
    //Generic yapı kullanarak, bu işlemleri her entity için tekrar yazmak yerine tek bir yerde tanımlıyoruz.
    //Eğer ortak işlemler dışında özelleştirilmiş işlemler varsa, o entity için ayrı bir interface tanımlarız.
    //DAL altında Abstarct içinde her bir entity için ayrı birer interface oluşturuldu.
    public interface IGenericDal<T> where T : class 
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
