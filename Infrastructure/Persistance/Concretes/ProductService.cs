using EticaretAPI.Domain.Entities;
using ETicaretAPI.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Concretes
{
    public class ProductService : IProductService
    {
        public List<Products> GetProducts() =>
            new() //Target Type Ozelligi
            {
                new() {id=Guid.NewGuid(), Name="Product 1", Stock=10,Price=22 },
                new() {id=Guid.NewGuid(), Name="Product 5", Stock=9,Price=65 },
                new() {id=Guid.NewGuid(), Name="Product 6", Stock=0,Price=67 },
                new() {id=Guid.NewGuid(), Name="Product 7", Stock=23,Price=32 },
            };
    }
}
