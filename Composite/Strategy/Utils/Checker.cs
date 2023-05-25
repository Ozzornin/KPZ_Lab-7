using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Strategy.Utils
{
    public static class HrefChecker
    {
        public static bool IsUrl(string path)
        {
            Uri uriResult;
            return Uri.TryCreate(path, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        public static bool IsFilePath(string path)
        {
            return System.IO.Path.IsPathRooted(path);
        }
    }
}
