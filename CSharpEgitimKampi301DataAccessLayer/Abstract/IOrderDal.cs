using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.EntityLayer.Conrete;

//Bu interface ile beraber hem CRUD işlemlerini aldık hem de ihtiyaç olması durumunda özel işlemler ekleyebiliriz.

namespace CSharpEgitimKampi301DataAccessLayer.Abstract
{
    public interface IOrderDal: IGenericDal<Order>
    {
    }
}
