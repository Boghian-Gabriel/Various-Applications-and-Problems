﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_To_SQLS.Classes
{
    public class Utils
    {
        public static string FilePath = Path.GetFullPath(AppContext.BaseDirectory);
        public static string FolderResources = "Resources";
        
        public static string GetFullResourcesPath(string sFileName)
        {
            string sFilePath = String.Empty;

            sFilePath = Path.Combine(FilePath, FolderResources, sFileName);

            return sFilePath;
        }
    }
}
