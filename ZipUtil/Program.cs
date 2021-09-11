using System.IO;
using System.IO.Compression;

namespace ZipUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2) return;
            string zipDir = args[0];
            string zippedFile = args[1];
            if (!Directory.Exists(zipDir)) return;
            if (File.Exists(zippedFile)) return;
            ZipFile.CreateFromDirectory(zipDir, zippedFile);
        }
    }
}
