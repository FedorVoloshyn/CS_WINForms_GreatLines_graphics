using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WINForms_GreatLines_graphics_
{
    class Context
    {
        private IGraphic _graphic;
        public Context(IGraphic graphic)
        {
            _graphic = graphic;
        }
        public void SetGraphic(IGraphic graphic)
        {
            _graphic = graphic;
        }
        public List<Point> ExecuteOperation(int panelHight, int panelWidth)
        {
            return _graphic.drawGraphic(panelHight, panelWidth);
        }

    }
}
