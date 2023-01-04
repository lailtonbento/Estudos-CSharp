using SistemaVendas.Model;

namespace SistemaVendas.Services.SellerService
{
    public interface ISellerService
    {

        List<Seller> FindAll();
        void Insert(Seller seller);
        void Remove(int id);
        Seller FindById(int id);
        void Update(Seller seller);
    }
}
