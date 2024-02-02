using Business.Service;
using DataLayer.Abstratcs;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Content;

public class ContactManager : IGenericService<Contact>, IContactService
{
    private readonly IContact _contact; 
    ContactManager(IContact contact)
    {
        _contact = contact;
    }
    public void TAdd(Contact contact)
    {
        _contact.Add(contact);
        
    }

    public List<Contact> TGetAll()
    {
       return _contact.GetAll();   
    }

    public Contact TGetById(int id)
    {
        return _contact.GetById(id);
    }

    public void TRemove(Contact t)
    {
        _contact.Delete(t);
    }

    public void TUpdate(Contact contact)
    {
        _contact.Update(contact);
    }
}
