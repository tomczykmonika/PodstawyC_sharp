using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module2
{
    internal class WordFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing WordFile");
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} printing...");

        }
    }
}
