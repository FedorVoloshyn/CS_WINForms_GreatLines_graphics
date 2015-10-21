using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WINForms_GreatLines_graphics_
{
    class GraphicEmpty : IGraphic
    {
        public List<Point> drawGraphic(int panelHight, int panelWidth)
        {
            return new List<Point>();
        }
    }
}
