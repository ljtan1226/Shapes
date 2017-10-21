using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cylinder:Circle//圆柱体
    {
    private double r;
    private double h;

    public double R
    {
        get { return this.r; }
        set { this.r = value; }
    }


    //新增构造函数，Circle类的初始化实例
    public Cylinder():base(0.0,0.0,0.0)
    {
        base.X = base.Y = 0;  //base表示其基类
        this.r = 1.0;
        this.h = 3.0;
    }

    //新增构造函数，Circle类的初始化实例
    public Cylinder(double x, double y, double radius,double high):base(x,y,radius)
    {
        base.X = x;
        base.Y = y;
        this.r = radius;
        this.h = high;
    }

    public double volume()
    {
        return   Math.PI * Math.Pow(this.r, 2)*this.h;
    }
    public override string ToString()
    {
        return "圆心坐标 = [" + base.X + "]" + "[" + base.Y + "] ,半径 = " + r+"圆柱体的高="+h;
    }

    ~Cylinder() { }
}

