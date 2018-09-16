using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class ProductCategory : BaseEntity
    {
        //Campo Id ahora es manejado desde clase BaseEntity
        //public string Id { get; set; }
        public string Category { get; set; }

        //Constructor ya no es necesario dado que el Id se maneja desde BaseEntity.
        /*
        public ProductCategory()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        */
    }
}
