using JuanFe.Supermarket.Product.Interface.Solution;
using Swashbuckle.Examples;
using System;

namespace JuanFe.Supermarket.Product.Solution.DataContracts
{
    public class ProductInput : IProduct, IExamplesProvider
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid IdProduct { get; set; }
        public short IdCategory { get; set; }
        public decimal Price { get; set; }

        public object GetExamples()
        {
            return new ProductInput
            {
                Description = "Bleach 350 ml",
                IdProduct = new Guid("1c7d3470-443f-4e0c-aa4f-e5caa84fb877"),
                Id = 728,
                IdCategory = 1,
                Name = "Bleach 350 ml",
                Price = 10m
            };
        }
    }
}
