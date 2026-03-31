using System;
using System.Collections.Generic;
using System.Linq;
using Magazine.Core.Models;
using Magazine.Core.Services;

namespace Magazine.WebApi
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new();

        public Product Add(Product product)
        {
            product.Id = Guid.NewGuid();
            _products.Add(product);
            return product;
        }

        public Product Remove(Guid id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);

            if (product == null)
                throw new Exception("Product not found");

            _products.Remove(product);
            return product;
        }

        public Product Edit(Product product)
        {
            var existing = _products.FirstOrDefault(x => x.Id == product.Id);

            if (existing == null)
                throw new Exception("Product not found");

            existing.Name = product.Name;
            existing.Definition = product.Definition;
            existing.Price = product.Price;
            existing.Image = product.Image;

            return existing;
        }

        public Product? Search(string name)
        {
            return _products.FirstOrDefault(x => x.Name == name);
        }
    }
}