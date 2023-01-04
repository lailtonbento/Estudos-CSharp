using SistemaVendas.Data;
using SistemaVendas.Model;
using Microsoft.EntityFrameworkCore;
using SistemaVendas.Exceptions;

namespace SistemaVendas.Services.SellerService
{
    public class SellerService : ISellerService
    {

        private readonly SistemaVendasContext _context;

        public SellerService(SistemaVendasContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id) {
            return _context.Seller.Include(seller => seller.Department).FirstOrDefault(seller => seller.Id == id);
        }

        public void Remove(int id) {
            var seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }

        public void Update(Seller seller) {
            if (!_context.Seller.Any(x => x.Id == seller.Id)) 
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(seller);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e) 
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
