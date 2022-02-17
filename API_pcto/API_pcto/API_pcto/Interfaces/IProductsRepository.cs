using API_pcto.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_pcto.Interfaces
{
    public interface IProductsRepository
    {
        public Task<IEnumerable<Prodotto>> GetProducts();
        public string CreateProduct(string nomeProdottoDaCercare);
    }
}
