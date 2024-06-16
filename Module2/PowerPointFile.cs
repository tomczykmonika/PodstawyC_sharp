using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module2
{
    internal class PowerPointFile : File
    {
        public override void Compress()
        {
            Console.WriteLine("Compressing PowerPointFile");
        }
        public void Present()
        {
            Console.WriteLine($"{FileName} presenting...");

        }
    }
}
