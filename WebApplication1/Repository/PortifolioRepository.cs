using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Repository
{
    public class PortifolioRepository
    {

        private readonly AppDbContext db;
        public PortifolioRepository(AppDbContext appDbContext)
        {
            this.db = appDbContext;
        }
        public IEnumerable<CompanyDetails> GetAllCompanyDetails()
        {
            return db.CompanyDetailsDb.ToList();
        }
    }
}
