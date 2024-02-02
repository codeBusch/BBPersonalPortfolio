using Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace BBPersonalPortfolio.ViewComponents.Contact;

public class ContactList : ViewComponent
{
    private readonly IContactService _contactService;
    ContactList(IContactService contactService)
    {
        _contactService = contactService;
    }
    public IViewComponentResult Invoke()
    {
        var values = _contactService.TGetAll();
        return View(values);
    }
}
