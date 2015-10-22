using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CS_WINForms_GreatLines_graphics_
{
    class GraphicStrophoid : IGraphic
    {
        public List<Point> drawGraphic(int panelHight, int panelWidth)
        {
            List<Point> currentGraphic = new List<Point>();
            int x = panelWidth / 2,
                y = panelHight / 2,
                a = panelWidth / 2,
                b = panelHight / 2;

            for (double angle = -3.1416 / 2; angle <= 3.1416 / 2; angle += 0.05) // Строфоида
            {
                Point currPoint = new Point();
                currPoint.X = Convert.ToInt32(a + 100 * (Math.Tan(angle) * Math.Tan(angle) - 1) / (Math.Tan(angle) * Math.Tan(angle) + 1));
                currPoint.Y = Convert.ToInt32(b + 100 * Math.Tan(angle) * ((Math.Tan(angle) * Math.Tan(angle) - 1) / (Math.Tan(angle) * Math.Tan(angle) + 1)));
                currentGraphic.Add(currPoint);
            }

            return currentGraphic;
        }
    }
}
