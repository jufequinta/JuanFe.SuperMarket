using JuanFe.Supermarket.Product.Interface.Solution;
using JuanFe.Supermarket.Product.Solution.Infrastructure.Helpers;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace JuanFe.Supermarket.Product.Solution.Infrastructure.BusinessLogic
{
    public class ProductBussinesLogic : IProductBussinesLogic
    {
        public async Task<Guid> AddProductProcess(IProduct product)
        {
            product.IdProduct = Guid.NewGuid();
            await ServiceBusHelper.SendMessageTopic("ProductTopic", JsonConvert.SerializeObject(product));
            return product.IdProduct;
        }
    }
}
