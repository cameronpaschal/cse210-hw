

public class Rectangle : Shape{


    private int _length;
    private int _height;

    public Rectangle(string color, int length, int height) :base(color){
        _length = length;
        _height = height;
    }

    public override double GetArea(){   
        return _length * _height;
    }
}