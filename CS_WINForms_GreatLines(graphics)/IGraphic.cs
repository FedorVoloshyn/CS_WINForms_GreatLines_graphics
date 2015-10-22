using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WINForms_GreatLines_graphics_
{
    public interface IGraphic
    {
        List<Point> drawGraphic(int panelHight, int panelWidth);
    }
}
