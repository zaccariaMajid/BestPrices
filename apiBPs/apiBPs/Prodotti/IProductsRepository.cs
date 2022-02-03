using apiBPs.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace apiBPs.Prodotti
{
    public interface IProductsRepository
    {
        public Task<IEnumerable<Prodotto>> GetProducts();
    }
}
