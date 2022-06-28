using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Sailor.Extension
{
    public static class FileExtension
    {
        public static bool IsOkay(this IFormFile file,int mb)
        {
            return file.Length < mb * 1024 * 1024 && file.ContentType.Contains("image");
        }

        public static bool IsMb(this IFormFile file,int mb)
        {
            return file.Length < mb * 1024 * 1024;
        }
    }
}
