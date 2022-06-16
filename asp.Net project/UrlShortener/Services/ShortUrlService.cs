using UrlShortener.Models;

namespace UrlShortener.Services;

public class ShortUrlService : IShortUrlService
{
    private List<ShortUrl> Urls { get; set; } = new List<ShortUrl>();
    private int _incrementor = 0;

    public string GetUrlById(int id)
    {
        var url = Urls.FirstOrDefault(u => u.Id == id);
        return url.OriginalUrl;
    }

    public int SaveUrl(string orignalUrl)
    {
        var shortUrl = new ShortUrl
        {
            Id = _incrementor,
            OriginalUrl = orignalUrl
        };
        Urls.Add(shortUrl);
        _incrementor++;
        return shortUrl.Id;
    }
}