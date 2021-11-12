using Ajándék_futószalag.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajándék_futószalag.Entities
{
    class PresentFactory : IToyFactory
    {
        public Color PresentColor { get; set; }

        public Toy CreateNew()
        {
            return new Ball(PresentColor);
        }
    }
}
