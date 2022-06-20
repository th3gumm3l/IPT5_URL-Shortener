using UrlShortener.Models;

namespace UrlShortener.Services;

public class ShortUrlService : IShortUrlService
{

    private List<ShortUrl> Urls { get; set; } = new List<ShortUrl>();
    private int _incrementor = 0;

    /// <summary>
    /// Gets the URL by the "ID" of the List
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Returns the first or default url</returns>
    public string GetUrlById(int id)
    {
        var url = Urls.FirstOrDefault(u => u.Id == id);
        return url.OriginalUrl;
    }

    /// <summary>
    /// Saves the new URL
    /// </summary>
    /// <param name="orignalUrl">stands for the original url</param>
    /// <returns>returns the shorter url with the "ID-Number"</returns>
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