using DataLayer.Abstratcs;
using DataLayer.Repositories;
using Model;

namespace DataLayer.EntityFrameWork;

public class EFService : GenericRepository<ModelService>, IService
{
    public EFService(ApplicationDbContext context) : base(context)
    {
    }
}