namespace UrlShortener.Services;

public interface IShortUrlService
{
    string GetUrlById(int id);
    int SaveUrl(string orignalUrl);
}
