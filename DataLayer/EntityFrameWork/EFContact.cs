using DataLayer.Abstratcs;
using DataLayer.Repositories;
using Model;

namespace DataLayer.EntityFrameWork;

public class EFContact : GenericRepository<Contact>, IContact
{
    public EFContact(ApplicationDbContext context) : base(context)
    {
    }
}
