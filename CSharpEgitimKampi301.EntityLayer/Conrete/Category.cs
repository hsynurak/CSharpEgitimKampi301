using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Conrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } //Product classında burada bulunan bilgilere erişim olmasını sağlamak için List kullanıyoruz.
    }
}

/*
 Field-Variable-Property
 int x; --> Direkt olarak sınıf içine tanımlanırsa FIELD
 int x; --> Class içinde sonunda get, set metotları varsa PROPERTY
 int x; --> Bir metot içinde tanımlanırsa VARIABLE
*/