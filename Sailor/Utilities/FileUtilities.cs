﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Sailor.Utilities
{
    public static class FileUtilities
    {
        public async static Task<string> FileCreate(this IFormFile file,string root,string folder)
        {
            string fileName = file.FileName;
            string filePath = Path.Combine(root, folder);
            string fullPath = Path.Combine(filePath, fileName);

            using(FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return fileName;
        }
    }
}
