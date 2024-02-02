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

        public void TAdd(About about)
        {
            _about.Add(about);
        }

        public List<About> TGetAll()
        {
           return _about.GetAll();
        }

        public About TGetById(int id)
        {
           return _about.GetById(id);
        }

        public void TRemove(About about)
        {
            _about.Remove(about);
        }

        public void TUpdate(About about)
        {
            _about.Update(about);
        }
    }
}
