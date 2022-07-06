using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Csharp_study
{
   
    class practice
    {
        
        static bool Str(string s)
        {
            string[] exts = new[] { ".bmp", ".txt", ".gif" };
            return exts.Contains(Path.GetExtension(s), StringComparer.OrdinalIgnoreCase);

        }
        static void GetFiles()
        {
            string path = @"d:\TestDirectory";
            DirectoryInfo dinfo = new DirectoryInfo(path);
            if(dinfo.Exists)
            {
                string[] exts = new[] { ".bmp", ".txt", ".gif" };
                FileInfo[] files = dinfo.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                string[] filestr = new string[files.Length];
                for (int i = 0; i < files.Length; i++)
                    filestr[i] = files[i].ToString();
                string[] result = filestr.Where(Str).ToArray();
                for(int i=0; i< result.Length; i++)
                    Console.WriteLine(result[i]);
            }
        }
        static void Main(string[] args)
        {
            GetFiles();

        }

    }
}
