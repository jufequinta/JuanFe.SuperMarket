using JuanFe.Supermarket.Product.Interface.Solution;
using Swashbuckle.Examples;

namespace JuanFe.Supermarket.Product.Solution.DataContracts
{
    public class ProductProviderInput : IProductProvider, IExamplesProvider
    {
        public long IdProduct { get; set; }
        public int IdProvider { get; set; }
        public double IdProductProvider { get; set; }

        public object GetExamples()
        {
            return new ProductProviderInput()
            {
                IdProduct = 1,
                IdProvider = 10,
                IdProductProvider = 1234,
            };
        }
    }
}
