using System.Reflection;

namespace FplClientTests;

internal static class EmbeddedData
{
    internal static string ReadEmbeddedData<T>(string embeddedFileName) where T : class
    {
        var assembly = typeof(T).GetTypeInfo().Assembly;
        using var stream = assembly.GetManifestResourceStream(embeddedFileName);
        
        if (stream is null)
        {
            throw new InvalidOperationException("Could not load manifest resource stream.");
        }

        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}