﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WINForms_GreatLines_graphics_
{
    class GraphicDiocalCissoid : IGraphic
    {
        public List<Point> drawGraphic(int panelHight, int panelWidth)
        {
            List<Point> currentGraphic = new List<Point>();
            int x = panelWidth / 2,
                y = panelHight / 2,
                a = panelWidth / 2,
                b = panelHight / 2;

            for (double angle = 0.01; angle <= 3.1416; angle += 0.05) // Циссоида Диокла
            {
                Point currPoint = new Point();
                currPoint.X = Convert.ToInt32(a + 100 * 2 / (1 + Math.Tan(angle) * Math.Tan(angle)));
                currPoint.Y = Convert.ToInt32(b + 100 * 2 / (Math.Tan(angle) * (1 + Math.Tan(angle) * Math.Tan(angle))));
                currentGraphic.Add(currPoint);
            }

            return currentGraphic;
        }
    }
}
