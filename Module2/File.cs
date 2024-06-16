using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module2
{
    abstract class File
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

        public abstract void Compress();
    }
}
