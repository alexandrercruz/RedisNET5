﻿using Aplicacao.Domain.Shared.Model;

namespace Aplicacao.Domain.Model
{
    public class Product : TEntity<int>
    {
        public Product()
        {

        }

        public Product(string description, float weight, string sKU, decimal price)
        {
            Description = description;
            Weight = weight;
            SKU = sKU;
            Price = price;
        }

        public string Description { get; private set; }

        public float Weight { get; private set; }

        public string SKU { get; private set; }

        public decimal Price { get; private set; }
    }
}