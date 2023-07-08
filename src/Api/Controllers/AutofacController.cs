using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("autofac")]
public class AutofacController : Controller
{
    private readonly IDateTimeService _dateTimeService;

    public AutofacController(
        IDateTimeService dateTimeService,
        IAccessService accessService)
    {
        _dateTimeService = dateTimeService;
    }

    [HttpGet]
    public string GetUtcDate()
    {
        return _dateTimeService.Now.ToLongTimeString();
    }
}