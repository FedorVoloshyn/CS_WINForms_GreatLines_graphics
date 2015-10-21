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
    class GraphicCardioid : IGraphic
    {
        public List<Point> drawGraphic(int panelHight, int panelWidth)
        {
            List<Point> currentGraphic = new List<Point>();
            int x = panelWidth / 2,
                y = panelHight / 2,
                a = panelWidth / 2,
                b = panelHight / 2;

            currentGraphic.Add(new Point(x, y));
            
            for (double angle = 0; angle <= 2 * 3.1416; angle += 0.05) // Кардиоида
            {
                Point currPoint = new Point();
                currPoint.X = Convert.ToInt32(a + 100 * (1 - Math.Cos(angle)) * Math.Cos(angle));
                currPoint.Y = Convert.ToInt32(b + 100 * (1 - Math.Cos(angle)) * Math.Sin(angle));
                currentGraphic.Add(currPoint);
            }

            return currentGraphic;
        }
    }
}
