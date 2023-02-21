using Onion.Application.Abstracts.Products;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Persistence.Concretes.Products
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
