using DataLayer.Abstratcs;
using DataLayer.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityFrameWork;

public class EFAbout : GenericRepository<About>, IAbout
{
    public EFAbout(ApplicationDbContext context) : base(context)
    {
    }
}

