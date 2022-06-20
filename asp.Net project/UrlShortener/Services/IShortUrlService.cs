namespace UrlShortener.Services;

public interface IShortUrlService
{
    /// <summary>
    /// Gets the URL by the "ID" of the List
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Returns the first or default url</returns>
    string GetUrlById(int id);

    /// <summary>
    /// Saves the new URL
    /// </summary>
    /// <param name="orignalUrl">stands for the original url</param>
    /// <returns>returns the shorter url with the "ID-Number"</returns>
    int SaveUrl(string orignalUrl);
}
