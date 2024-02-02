using DataLayer.Abstratcs;
using DataLayer.Repositories;
using Model;

namespace DataLayer.EntityFrameWork;

public class EFSocialMedia : GenericRepository<SocialMedia>, ISocialMedia
{
    public EFSocialMedia(ApplicationDbContext context) : base(context)
    {
    }
}
