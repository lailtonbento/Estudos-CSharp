using System.Reflection.Metadata.Ecma335;

namespace SistemaVendas.Model.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
