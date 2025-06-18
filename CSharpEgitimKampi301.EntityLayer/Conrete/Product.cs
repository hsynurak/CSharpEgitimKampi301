 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Conrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }  //Bunun ile beraber CategoryId bilgisini alabiliyorum.
                                                        //Aynı zamanda bu iletişimin sağlanabilmesi için Category class içine List kullanarak Product classını bildiriyorum.
        public List<Order> Orders { get; set; }

        [NotMapped]
        public string CategoryName { get; set; }
    }
}
