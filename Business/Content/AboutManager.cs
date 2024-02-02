using Business.Service;
using DataLayer.Abstratcs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content
{
    public class AboutManager : IGenericService<About>, IAboutService
    {
        private readonly IAbout _about;
        public AboutManager(IAbout about)
        {
            _about = about;
        }

        public void TAdd(About t)
        {
          _about.Add(t);
        }

        public List<About> TGetAll()
        {
            throw new NotImplementedException();
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(About t)
        {
           _about.Remove(t);
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
