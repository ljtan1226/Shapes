using System;

public class TestMain
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(37, 43, 2.5);
       
        Console.WriteLine("该圆的圆心的坐标是:{0},{1}", circle.X, circle.Y);
        circle.X = 30;
        circle.Y = 30;

        Console.WriteLine("该圆的新圆心坐标是:{0},{1}", circle.X, circle.Y);
        Console.WriteLine("该圆的周长是：{0},该圆的面积是：{1}", circle.CircumFerence(), circle.Area());
        //圆柱体
        Cylinder cylinder = new Cylinder(10, 20, 2,3);

        Console.WriteLine("该圆柱体的体积是:{0} ",cylinder.volume());

        //点
        Point point1 = new Point(1, 1);
        Console.WriteLine("该点的坐标是：{0}", point1.ToString());
      
        Point point2 = new Point(1, 5);
        
        Point point3 = new Point(5, 1);
        //线
        Line line1 = new Line(point1,point2);
        Console.WriteLine("线1的长度是：{0},线1的斜率是：{1}",line1.Length(),line1.Slope());
        Line line2 = new Line(point2, point3);
        Line line3 = new Line(point3, point1);
        //三角形用点创建
        Triangle triangle1 = new Triangle(point1, point2, point3);
        Console.WriteLine("该三角形的面积为：", triangle1.Area());
        //三角形用线创建
        Triangle triangle2 = new Triangle(line1, line2, line3);
        Console.WriteLine("线1的长度是：{0}", triangle2.l2.Length());
        Console.WriteLine("该三角形的周长为：", triangle2.Perimeter());
        //四边形
        Quadrilateral quadrilateral1 = new Quadrilateral();
        quadrilateral1.draw("四边形");
        //梯形
        Trapaezoid trapaezoid1 = new Trapaezoid();
        trapaezoid1.draw(3);
        //平行四边形
        Parallelogram parallelogram1 = new Parallelogram();
        parallelogram1.draw();
        //长方形
        Rectangle rectangle = new Rectangle();
        rectangle.display();
        //菱形
        Rhombus rhombus = new Rhombus();
        rhombus.display();
        //正方形
        Quadrate quadrate = new Quadrate();
        quadrate.draw();
        Console.ReadLine();
    }
}
