using DataLayer.Abstratcs;
using DataLayer.Repositories;
using Model;

namespace DataLayer.EntityFrameWork;

public class EFPortfolio : GenericRepository<Portfolio>, IPortfolio
{
    public EFPortfolio(ApplicationDbContext context) : base(context)
    {
    }
}
