using System;

namespace Facade
{
    public class Facade
    {
        public string filename { get; set; }

        public Facade(string filename)
        {
            this.filename = filename;
        }

        public void Build()
        {
            var scanner = new Scanner();
            var parser = new Parser();
            var codegen = new CodeGenerator();

            Console.WriteLine($"filename: {filename}");

            if (filename.EndsWith(".cs") || filename.EndsWith(".vb"))
            {
                scanner.Scan(filename);
                parser.Parse();
                codegen.Generate();
                Console.WriteLine("done.\n");
            } else
            {
                Console.WriteLine($"{filename} cannot be built.\n");
            }
            
        }
    }
}
