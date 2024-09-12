using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using Lab_1_vss.Figures;

namespace Lab_1_vss
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Triangle_Click(object sender, RoutedEventArgs e)
        {
            ClearScene();

            Triangle tr;
            Random rnd = new Random();

            Point2D p1 = new Point2D(rnd.Next(0, (int)Drawing_Field.Width), rnd.Next(0, (int)Drawing_Field.Height));
            Point2D p2 = new Point2D(rnd.Next(0, (int)Drawing_Field.Width), rnd.Next(0, (int)Drawing_Field.Height));
            Point2D p3 = new Point2D(rnd.Next(0, (int)Drawing_Field.Width), rnd.Next(0, (int)Drawing_Field.Height));

            tr = new Triangle(p1, p2, p3);

            DrawLine(tr.getP1(), tr.getP2());
            DrawLine(tr.getP2(), tr.getP3());
            DrawLine(tr.getP3(), tr.getP1());
        }

        private void Button_Rect_Click(object sender, RoutedEventArgs e)
        {
            ClearScene();

            Rectan rc;
            Random rnd = new Random();

            Point2D p1 = new Point2D(rnd.Next(0, (int)Drawing_Field.Width), rnd.Next(0, (int)Drawing_Field.Height));

            Point2D p2 = new Point2D(p1.getX(), p1.getY());

            int sideX = rnd.Next(0, (int)Drawing_Field.Height - 100);

            int sideY = rnd.Next(0, (int)Drawing_Field.Width - 100);
            p2.shiftY(sideX);

            Point2D p3 = new Point2D(p1.getX(), p1.getY());
            p3.shiftX(sideY);

            Point2D p4 = new Point2D(p3.getX(), p2.getY());

            rc= new Rectan(p1, p2, p3, p4);

            DrawLine(rc.getP1(), rc.getP2());
            DrawLine(rc.getP2(), rc.getP4());
            DrawLine(rc.getP4(), rc.getP3());
            DrawLine(rc.getP3(), rc.getP1());
        }

        private void Button_Square_Click(object sender, RoutedEventArgs e)
        {
            ClearScene();

            Square sq;
            Random rnd = new Random();

            Point2D p1 = new Point2D(rnd.Next(0, (int)Drawing_Field.Width), rnd.Next(0, (int)Drawing_Field.Height));

            Point2D p2 = new Point2D(p1.getX(),p1.getY());

            int sideY = rnd.Next(0, (int)Drawing_Field.Width - 200);
            p2.shiftY(sideY);

            Point2D p3 = new Point2D(p1.getX(), p1.getY());
            p3.shiftX(sideY);

            Point2D p4 = new Point2D(p3.getX(), p2.getY());

            sq = new Square(p1, p2, p3, p4);

            DrawLine(sq.getP1(), sq.getP2());
            DrawLine(sq.getP2(), sq.getP4());
            DrawLine(sq.getP4(), sq.getP3());
            DrawLine(sq.getP3(), sq.getP1());
        }

        private void SliderOX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void SliderOY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        public void DrawLine(Point2D p1, Point2D p2)
        {
            //Создание новой линии
            Line line = new Line();

            //Цвет и толщина линии
            line.Stroke = Brushes.Navy;
            line.StrokeThickness = 2;

            //Установка координат линии из координат точек Point2D
            line.X1 = p1.getX();
            line.Y1 = p1.getY();
            line.X2 = p2.getX();
            line.Y2 = p2.getY();

            //Добавление линии в Canvas
            Drawing_Field.Children.Add(line);
        }

        public void ClearScene()
        {
            //Очистка Canvas от всех объектов
            Drawing_Field.Children.Clear();
        }

        private void Button_Eraser(object sender, RoutedEventArgs e)
        {
            ClearScene();
        }
    }


}
