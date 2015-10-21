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
            Graphics g = panel1.CreateGraphics();
            Context currentGraphic = new Context(new GraphicEmpty());

            switch(comboBox1.SelectedIndex)
            {
                case 0: // Кардиоида
                    currentGraphic.SetGraphic(new GraphicCardioid());
                    break;
                case 1: // Строфоида
                    currentGraphic.SetGraphic(new GraphicStrophoid());
                    break;
                case 2: // Циссоида Диокла
                    currentGraphic.SetGraphic(new GraphicDiocalCissoid());
                    break;
                case 3: // Декартов лист
                    currentGraphic.SetGraphic(new GraphicDecartLeaf());
                    break;
                case 4: // Верзьера Аньези
                    currentGraphic.SetGraphic(new GraphicAniezyVerziery());
                    break;
                case 5: // Конхоида Никомеда
                    currentGraphic.SetGraphic(new GraphicNicomedKonkhoid());
                    break;
                default: 
                    break;
            }

            DrawGraphic(currentGraphic, g);
            DrawAxeses(g);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void DrawAxeses(Graphics g)
        {
            g = panel1.CreateGraphics();
            g.DrawLine(axesPen, panel1.Width / 2, 0, panel1.Width / 2, panel1.Height);
            g.DrawLine(axesPen, 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);
        }

        private void DrawGraphic(Context currentGraphic, Graphics g)
        {
            List<Point> graphicPoints = currentGraphic.ExecuteOperation(panel1.Height, panel1.Width);
            for (int i = 0; i < graphicPoints.Count - 1; i++)
            {
                Point prevPoint = new Point(graphicPoints[i]);
                g.DrawLine(graphPen, prevPoint.X, prevPoint.Y, graphicPoints[i + 1].X, graphicPoints[i + 1].Y);
            }
        }
        
    }
}
