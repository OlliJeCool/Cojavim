using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoJaVim
{
    internal class Core
    {
        public void Run()
        {
            int counter = 0;
            var sr = new StreamReader("./input.txt");
            string? line;
            while ((line = sr.ReadLine())!= null)
            {
                counter += line.Replace(" ", "").Split(";")[5] == "true" ? 1 : 0;
            }
            using var sw = new StreamWriter("./output.txt");
            sw.WriteLine($"{DateTime.Now};{counter}");
        }
    }
}
