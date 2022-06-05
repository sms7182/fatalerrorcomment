using Relex.BrandReputation.Core.AppSettings;
using Relex.BrandReputation.Domain.DomainServices;

namespace Relex.BrandReputation.Service.Resolvers
{

   
    public class ContentTruncateResolver : IContentTruncateResolver
    {
        public ContentTruncateResolver(IContentTruncateLengthResolver lengthResolver)
        {
            LengthResolver = lengthResolver;
        }

        private IContentTruncateLengthResolver LengthResolver { get; }

        public string Truncate(string content)
        {
            return content.Truncate(LengthResolver.ResolveLength());
        }
    }
    public static class StringExtension
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            return value.Length <= maxLength ? value : value[..maxLength];
        }
    }

    public class ContentTruncateLengthResolver : IContentTruncateLengthResolver
    {
        public ContentTruncateLengthResolver(GlobalAppSettings globalAppSettings)
        {
            GlobalAppSettings = globalAppSettings;
        }

        private GlobalAppSettings GlobalAppSettings { get; }


        public int ResolveLength()
        {
            return GlobalAppSettings.ContentTruncatedLength.GetValueOrDefault(20);
        }
    }
}
