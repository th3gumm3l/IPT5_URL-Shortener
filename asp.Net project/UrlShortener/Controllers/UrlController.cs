using Microsoft.AspNetCore.Mvc;
using UrlShortener.Services;

namespace UrlShortener.Controllers;

[ApiController]
[Route("[controller]")]
public class UrlController : ControllerBase
{
    private readonly IShortUrlService _shortUrlService;

    public UrlController(IShortUrlService shortUrlService)
    {
        _shortUrlService = shortUrlService;
    }

    [HttpPost]
    public IActionResult CreateUrl(string originalUrl)
    {
        var urlId = _shortUrlService.SaveUrl(originalUrl);
        return Ok(urlId);
    }

    [HttpGet]
    public IActionResult RedirectTo(int id)
    {
        var url = _shortUrlService.GetUrlById(id);
        return Redirect(url);
    }
}