using DataLayer.Abstratcs;
using DataLayer.Repositories;
using Model;

namespace DataLayer.EntityFrameWork;

public class EFMessage : GenericRepository<Message>, IMessage
{
    public EFMessage(ApplicationDbContext context) : base(context)
    {
    }
}
