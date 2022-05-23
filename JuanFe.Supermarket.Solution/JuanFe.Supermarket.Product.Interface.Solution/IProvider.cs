using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanFe.Supermarket.Product.Interface.Solution
{
    public interface IProvider
    {
        Int32 Id { get; set; }
        string Name { get; set; }
    }
}
