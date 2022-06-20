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

    /// <summary>
    /// Post Request to Website
    /// </summary>
    /// <param name="originalUrl"></param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult CreateUrl(string originalUrl)
    {
        var urlId = _shortUrlService.SaveUrl(originalUrl);
        return Ok(urlId);
    }

    /// <summary>
    /// Get Request to Website
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    public IActionResult RedirectTo(int id)
    {
        var url = _shortUrlService.GetUrlById(id);
        return Redirect(url);
    }

    //Created by Yazdan Musa: https://github.com/Zayden16
    // I asked Yazdan for help and he explained me what he's going to do. In the end he wrote this page for me, because he works daily with asp.NET
}