using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanFe.Supermarket.Product.Interface.Solution
{
    public interface IProductBussinesLogic
    {
        Task<Guid> AddProductProcess(IProduct product);
    }
}
