using JuanFe.Supermarket.Product.Interface.Solution;
using Swashbuckle.Examples;

namespace JuanFe.Supermarket.Product.Solution.DataContracts
{
    public class ProviderInput : IProvider, IExamplesProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public object GetExamples()
        {
            return new ProviderInput()
            {
                Id = 1,
                Name = "Hawkins"
            };
        }
    }
}
