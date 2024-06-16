using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyC_.Module2
{
    /* Różnice między interface'm, a lnterface'm
     * - Wszystkie obiekty interface'u są abstrakcyjne i publiczne, dlatego 
     * muszą być zaimplementowane w klasie, w której implementujemy inteface
     * - Klasa może dziedzić po tylko jednej klasie bazowej.
     * Inteface'ów natomiast w danej klasie można zaimplementować wiele.
     * - W inteface'ie nie można definiować konstruktorów.
     * 
     */

    interface IFile
    {
        string FileName { get; set; }
        int Size { get; set; }
        DateTime CreatedOn { get; set; }

        void Compress();
    }
}
