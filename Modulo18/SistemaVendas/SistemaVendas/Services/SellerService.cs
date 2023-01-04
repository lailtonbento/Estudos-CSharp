using SistemaVendas.Data;
using SistemaVendas.Model;

namespace SistemaVendas.Services
{
    public class SellerService : ISellerService
    {

        private readonly SistemaVendasContext _context;

        public SellerService(SistemaVendasContext context) {
            _context= context;
        }

        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();       
        }
    }
}
