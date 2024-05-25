using System.Net;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApi.Models.Form;

namespace SimpleWebApi.Controllers;

[ApiController]
[Route("/api/contact-form")]
public class ContactFormController : ControllerBase
{
    private readonly ILogger<ContactFormController> _logger;
    
    private readonly ApplicationContext _applicationContext;

    public ContactFormController(
        ILogger<ContactFormController> logger,
        ApplicationContext applicationContext
        )
    {
        _logger = logger;
        _applicationContext = applicationContext;
    }

    [HttpPost(Name = "contact-form")]
    public async Task<HttpStatusCode> ContactForm([FromBody]ContactForm contactForm)
    {
        contactForm.CreatedOn = DateTimeOffset.Now.ToUnixTimeSeconds();
        
        _applicationContext.ContactForms.Add(contactForm);
        await _applicationContext.SaveChangesAsync();

        return HttpStatusCode.Created;
    }
}
