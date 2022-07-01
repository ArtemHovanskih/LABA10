using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Size = new Size(917, 600);
            //Создание прямоугольников
            Region region1 = new Region(new Rectangle(0, 300, 900, 300));
            Region region2 = new Region(new Rectangle(0, 0, 900, 300));
            //Создание неба (заливка прямоугольника)
            SolidBrush solidBrush2 = new SolidBrush(Color.SkyBlue);
            e.Graphics.FillRegion(solidBrush2, region2);
            //Создание и заливки горы
            PointF point11 = new PointF(150.0F, 300.0F);
            PointF point21 = new PointF(250.0F, 100.0F);
            PointF point31 = new PointF(350.0F, 300.0F);
            PointF[] points1 = { point11, point21, point31 };
            SolidBrush solidBrush5 = new SolidBrush(Color.Gray);
            e.Graphics.FillClosedCurve(solidBrush5, points1);
            //Создание и заливка снежной шапки
            PointF point12 = new PointF(200.0F, 160.0F);
            PointF point22 = new PointF(250.0F, 100.0F);
            PointF point32 = new PointF(300.0F, 160.0F);
            PointF[] points2 = { point12, point22, point32 };
            SolidBrush solidBrush7 = new SolidBrush(Color.White);
            e.Graphics.FillClosedCurve(solidBrush7, points2);
            //Создание травы (заливка прямоугольника)
            SolidBrush solidBrush1 = new SolidBrush(Color.Green);
            e.Graphics.FillRegion(solidBrush1, region1);
            //Создание солнца (круг с заливкой)
            SolidBrush solidBrush3 = new SolidBrush(Color.Yellow);
            e.Graphics.FillEllipse(solidBrush3, 600, 130, 70, 70);
            //Создание холмов (эллипсы с заливкой)
            SolidBrush solidBrush4 = new SolidBrush(Color.Green);
            e.Graphics.FillEllipse(solidBrush4, 150, 250, 300, 100);
            e.Graphics.FillEllipse(solidBrush4, 75, 200, 150, 170);
            e.Graphics.FillEllipse(solidBrush4, 20, 270, 100, 75);
            //Создание озера (эллипсы с заливкой)
            SolidBrush solidBrush6 = new SolidBrush(Color.Blue);
            e.Graphics.FillEllipse(solidBrush6, 100, 400, 540, 70);
            e.Graphics.FillEllipse(solidBrush6, 170, 430, 200, 70);
            //Создание птиц (кисть, кривая Бэзье)
            SolidBrush solidBrush8 = new SolidBrush(Color.Black);
            Pen pen1 = new Pen(solidBrush8, 2);
            e.Graphics.DrawBezier(pen1, 350.0F, 60.0F, 357.0F, 50.0F, 368.0F, 50.0F, 375.0F, 60.0F);
            e.Graphics.DrawBezier(pen1, 375.0F, 60.0F, 382.0F, 50.0F, 393.0F, 50.0F, 400.0F, 60.0F);
            e.Graphics.DrawBezier(pen1, 400.0F, 80.0F, 407.0F, 70.0F, 418.0F, 70.0F, 425.0F, 80.0F);
            e.Graphics.DrawBezier(pen1, 425.0F, 80.0F, 432.0F, 70.0F, 443.0F, 70.0F, 450.0F, 80.0F);
            //Создание лучей (линии и штрихи)
            Pen pen2 = new Pen(solidBrush3, 2);
            e.Graphics.DrawLine(pen2, 600.0F, 200.0F, 530.0F, 270.0F);
            e.Graphics.DrawLine(pen2, 580.0F, 160.0F, 450.0F, 170.0F);
            e.Graphics.DrawLine(pen2, 645.0F, 220.0F, 640.0F, 285.0F);

            float[] dash1 = { 15, 3, 10 };
            float[] dash2 = { 10, 1, 8 };
            pen2.DashPattern = dash1;
            e.Graphics.DrawLine(pen2, 574.0F, 180.0F, 480.0F, 230.0F);
            pen2.DashPattern = dash2;
            e.Graphics.DrawLine(pen2, 615.0F, 215.0F, 585.0F, 275.0F);
            //Создание облака (сплайн)
            PointF point13 = new PointF(650.0F, 80.0F);
            PointF point23 = new PointF(680.0F, 40.0F);
            PointF point33 = new PointF(710.0F, 45.0F);
            PointF point43 = new PointF(760.0F, 30.0F);
            PointF point53 = new PointF(810.0F, 45.0F);
            PointF point63 = new PointF(850.0F, 40.0F);
            PointF point73 = new PointF(870.0F, 80.0F);
            PointF[] points3 = { point13, point23, point33, point43, point53, point63, point73 };
            e.Graphics.FillClosedCurve(solidBrush7, points3);
            //Создание маленького облака (3 эллипса)
            e.Graphics.FillEllipse(solidBrush7, 500, 100, 55, 20);
            e.Graphics.FillEllipse(solidBrush7, 520, 110, 55, 20);
            e.Graphics.FillEllipse(solidBrush7, 470, 110, 65, 20);

        }
    }
}
