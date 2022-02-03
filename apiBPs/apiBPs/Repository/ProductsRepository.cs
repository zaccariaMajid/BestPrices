using apiBPs.Context;
using apiBPs.Entities;
using apiBPs.Prodotti;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBPs.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly DapperContext _context;
        public ProductsRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Prodotto>> GetProducts()
        {
            var query = "SELECT * FROM prodotto";
            using (var connection = _context.CreateConnection())
            {
                var prodotti = await connection.QueryAsync<Prodotto>(query);
                return prodotti.ToList();
            }
        }
    }
}
