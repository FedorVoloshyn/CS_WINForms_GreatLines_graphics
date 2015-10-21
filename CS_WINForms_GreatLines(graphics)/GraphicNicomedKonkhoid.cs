using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WINForms_GreatLines_graphics_
{
    class GraphicNicomedKonkhoid : IGraphic
    {
        public List<Point> drawGraphic(int panelHight, int panelWidth)
        {
            List<Point> currentGraphic = new List<Point>();
            int x = panelWidth / 2,
                y = panelHight / 2,
                a = panelWidth / 2,
                b = panelHight / 2;

            for (double angle = -3.1416 / 2; angle <= 3.1416 + 3.1416 / 2; angle += 0.04) // Конхоида Никомеда
            {
                Point currPoint = new Point();
                currPoint.X = Convert.ToInt32(a + 100 * (0.6 * Math.Cos(angle)));
                currPoint.Y = Convert.ToInt32(b + 100 * (0.6 * Math.Tan(angle) + 1.2 * Math.Sin(angle)));
                currentGraphic.Add(currPoint);
            }

            return currentGraphic;
        }
    }
}
