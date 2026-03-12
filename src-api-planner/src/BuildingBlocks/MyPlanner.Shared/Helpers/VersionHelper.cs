using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlanner.Shared.Helpers
{
    public static class VersionHelper
    {
        public static string Version { get; set; } = "0.0.0";

        public static bool IsValidVersion(string version)
        {
            if (string.IsNullOrWhiteSpace(version))
            {
                return false;
            }
            var parts = version.Split('.');
            if (parts.Length != 3)
            {
                return false;
            }
            foreach (var part in parts)
            {
                if (!int.TryParse(part, out _))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
