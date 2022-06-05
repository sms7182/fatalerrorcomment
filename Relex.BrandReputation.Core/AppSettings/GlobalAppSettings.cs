using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relex.BrandReputation.Core.AppSettings
{
    public class GlobalAppSettings
    {
        public static GlobalAppSettings Instance =
                     new();

        public GlobalAppSettings()
        {
            Instance = this;
        }

        public ConnectionStrings ConnectionStrings { get; set; } = new();

        public int? ContentTruncatedLength { get; set; }

    }

    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; } = String.Empty;
    }
}
