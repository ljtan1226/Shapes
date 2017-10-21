using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class Triangle:Shape //Triangle类，包含三个Point，采用sealed,表示是继承树的根类
{
    public Point p1;
    public  Point p2;
    public Point p3;
    public Line l1;//没写访问控制符，相当于默认protected，只能被其派生类使用
    public Line l2;
    public Line l3;

   

    //用点初始化Triangle类的实例
    public Triangle(Point point1, Point point2, Point point3)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
    }

    //用线初始化Triangle类的实例
    public Triangle(Line line1, Line line2, Line line3)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
    }

    //返回三角形的周长
    public override double Perimeter()
    {
       return this.l1.Length()+this.l2.Length()+this.l3.Length();
    }

    //返回三角形的面积
    public override double Area() 
    {
        return 1/2 * (p1.X*p2.Y+ p2.X*p3.Y+p3.X*p1.Y-p1.X*p3.Y-p2.X*p1.Y-p3.X*p2.Y);
    }

    public bool IsEquicrural()//判断是否为等腰三角形
    { return false; //you name it 
    }

    public bool IsEquilateral()//判断是否为等边三角形
    { return false; //you name it 
    }

    public override string ToString()
    {  return null; //you name it.;
    }

}