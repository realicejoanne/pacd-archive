using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prak04
{
    public class Operator
    {
        public int
            TopLeft = 0,
            TopMid = 0,
            TopRight = 0,
            MidLeft = 0,
            Pixel = 0,
            MidRight = 0,
            BottomLeft = 0,
            BottomMid = 0,
            BottomRight = 0,
            Factor = 1,
            Offset = 1;

        public void SetAll(int nVal)
        {
            TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = nVal;
        }
    }
}
