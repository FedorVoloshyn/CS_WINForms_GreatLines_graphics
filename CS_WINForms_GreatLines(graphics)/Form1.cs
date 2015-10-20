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
    public partial class Form1 : Form
    {
        private Pen axesPen, graphPen;

        public Form1()
        {
            InitializeComponent();
            axesPen = new Pen(Color.Black);
            graphPen = new Pen(Color.Red);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            axesPen.Color = colorDialog1.Color;
            panel1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            graphPen.Color = colorDialog1.Color;
            panel1.Invalidate();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
            Pen myPen = new Pen(Color.Red);
            gr.DrawEllipse(myPen, e.X - 1, e.Y - 1, 2, 2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            double angle;
            int x = panel1.Width / 2, 
                y = panel1.Height / 2, 
                xPrev = 0, 
                yPrev = 0,
                a = panel1.Width / 2,
                b = panel1.Height / 2;
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(axesPen, panel1.Width / 2, 0, panel1.Width / 2, panel1.Height);
            g.DrawLine(axesPen, 0, panel1.Height/2, panel1.Width, panel1.Height/2);
            int curGraph = comboBox1.SelectedIndex;
            switch(curGraph)
            {
                case 0:
                    for (angle = 0; angle <= 2 * 3.1416; angle += 0.08) // Кардиоида
                    {
                        xPrev = x;
                        yPrev = y;
                        x = Convert.ToInt32(a + 100 * (1 - Math.Cos(angle)) * Math.Cos(angle));
                        y = Convert.ToInt32(b + 100 * (1 - Math.Cos(angle)) * Math.Sin(angle));
                        g.DrawLine(graphPen, xPrev, yPrev, x, y);
                        Thread.Sleep(1);
                    }
                    break;
                case 1:
                    {
                        int timer = 1;
                        for (angle = -3.1416 / 2; angle <= 3.1416 / 2; angle += 0.05) // Строфоида
                        {
                        A:
                            xPrev = x;
                            yPrev = y;
                            x = Convert.ToInt32(a + 100 * (Math.Tan(angle) * Math.Tan(angle) - 1) / (Math.Tan(angle) * Math.Tan(angle) + 1));
                            y = Convert.ToInt32(b + 100 * Math.Tan(angle) * ((Math.Tan(angle) * Math.Tan(angle) - 1) / (Math.Tan(angle) * Math.Tan(angle) + 1)));
                            if (angle == -3.1416 / 2 && --timer == 0)
                                goto A;
                            g.DrawLine(graphPen, xPrev, yPrev, x, y);
                            Thread.Sleep(1);
                        }
                    }
                    break;
                case 2:
                    {
                        int timer = 1;
                        for (angle = 0.01; angle <= 3.1416; angle += 0.03) // Циссоида Диокла
                        {
                        A:
                            xPrev = x;
                            yPrev = y;
                            x = Convert.ToInt32(a + 100 * 2 / (1 + Math.Tan(angle) * Math.Tan(angle)));
                            y = Convert.ToInt32(b + 100 * 2 / (Math.Tan(angle) * (1 + Math.Tan(angle) * Math.Tan(angle))));
                            if (angle == 0.01 && --timer == 0)
                                goto A;
                            g.DrawLine(graphPen, xPrev, yPrev, x, y);
                            Thread.Sleep(1);
                        }
                    }
                    break;
                case 3:
                    {
                        int timer = 1;
                        for (angle = -3.1416 / 4; angle <= 3.1416 - 3.1416 / 4; angle += 0.03) // Декартов лист
                        {
                        A:
                            xPrev = x;
                            yPrev = y;
                            x = Convert.ToInt32(a + 100 * 3 * Math.Tan(angle) / (1 + Math.Tan(angle) * Math.Tan(angle) * Math.Tan(angle)));
                            y = Convert.ToInt32(b + 100 * 3 * Math.Tan(angle) * Math.Tan(angle) / (1 + Math.Tan(angle) * Math.Tan(angle) * Math.Tan(angle)));
                            if (angle == -3.1416 / 4 && --timer == 0)
                                goto A;
                            g.DrawLine(graphPen, xPrev, yPrev, x, y);
                            Thread.Sleep(1);
                        }
                    }
                    break;

                case 4:
                    {
                        int timer = 1;
                        for (angle = 0; angle <= 3 * 3.1416; angle += 0.06) // Верзьера Аньези
                        {
                        A:
                            xPrev = x;
                            yPrev = y;
                            x = Convert.ToInt32(angle * 100.0);
                            double k = -a + 100.0 * angle;
                            y = Convert.ToInt32(b - 50.0 * (8.0 / (4.0 + k * k / 500.0)));
                            if (angle == 0 && --timer == 0)
                                goto A;
                            g.DrawLine(graphPen, xPrev, yPrev, x, y);
                            Thread.Sleep(1);
                        }
                    }
                    break;

                case 5:
                    {
                        int timer = 1;
                        for (angle = -3.1416 / 2; angle <= 3.1416 + 3.1416 / 2; angle += 0.04) // Конхоида Никомеда
                        {
                        A:
                            xPrev = x;
                            yPrev = y;
                            x = Convert.ToInt32(a + 100 * (0.6 * Math.Cos(angle)));
                            y = Convert.ToInt32(b + 100 * (0.6 * Math.Tan(angle) + 1.2 * Math.Sin(angle)));
                            if (angle == -3.1416 / 2 && --timer == 0)
                                goto A;
                            g.DrawLine(graphPen, xPrev, yPrev, x, y);
                            Thread.Sleep(1);
                        }
                    }
                    break;
                default: 
                    break;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
        
    }
}
