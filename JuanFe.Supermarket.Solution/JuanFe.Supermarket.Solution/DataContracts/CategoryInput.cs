using JuanFe.Supermarket.Product.Interface.Solution;
using Swashbuckle.Examples;

namespace JuanFe.Supermarket.Product.Solution.DataContracts
{
    public class CategoryInput : ICategory, IExamplesProvider
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public object GetExamples()
        {
            return new CategoryInput()
            {
                Description = "Cleaning Products",
                Id = 1,
                Name = "Cleaning Products"
            };
        }
    }
}
