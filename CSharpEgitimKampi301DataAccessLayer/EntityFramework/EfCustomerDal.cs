using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.EntityLayer.Conrete;
using CSharpEgitimKampi301DataAccessLayer.Abstract;
using CSharpEgitimKampi301DataAccessLayer.Repositories;

namespace CSharpEgitimKampi301DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
    }
}
