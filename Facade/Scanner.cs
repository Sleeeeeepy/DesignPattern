using System;

namespace Facade
{
    public class Scanner
    {
        public void Scan(string filename)
        {
            Console.WriteLine($"The scanner is reading {filename}...");
            Console.WriteLine($"The scanner is tokenizing {filename}");
        }
    }
}
