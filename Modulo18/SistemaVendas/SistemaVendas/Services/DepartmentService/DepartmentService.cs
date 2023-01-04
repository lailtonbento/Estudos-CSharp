using SistemaVendas.Data;
using SistemaVendas.Model;

namespace SistemaVendas.Services.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly SistemaVendasContext _context;

        public DepartmentService(SistemaVendasContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList();
        }

    }
}
