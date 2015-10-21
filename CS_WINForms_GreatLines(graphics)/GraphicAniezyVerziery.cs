using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WINForms_GreatLines_graphics_
{
    class GraphicAniezyVerziery : IGraphic
    {
        public List<Point> drawGraphic(int panelHight, int panelWidth)
        {
            List<Point> currentGraphic = new List<Point>();
            int x = panelWidth / 2,
                y = panelHight / 2,
                a = panelWidth / 2,
                b = panelHight / 2;

            int timer = 1;
            for (double angle = 0; angle <= 3 * 3.1416; angle += 0.05) // Верзьера Аньези
            {
            A:
                Point currPoint = new Point();
                currPoint.X = Convert.ToInt32(angle * 100.0);
                double k = -a + 100.0 * angle;
                currPoint.Y = Convert.ToInt32(b - 50.0 * (8.0 / (4.0 + k * k / 500.0)));
                if (angle == 0 && --timer == 0)
                    goto A;
                currentGraphic.Add(currPoint);
            }

            return currentGraphic;
        }
    }
}
