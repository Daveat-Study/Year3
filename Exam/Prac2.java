abstract class Shape{
	private String color;
	
	Shape(){
		color = "Green";
	}
	
	Shape(String cl){
		color = cl;
	}
	
	public String getColor() {
		return color;
	}
	
	public void setColor(String cl) {
		color = cl;
	}
	
	abstract double getArea();
	abstract double getPerimeter();
	
}

class Circle  extends Shape{
	
	private double radius;
	
	Circle(){
		radius = 0;
	}
	
	Circle(double rd){
		radius = rd;
	}
	
	public double getRadius() {
		return radius;
	}
	
	public void setRadius(double rd) {
		radius = rd;
	}
	
	public double getArea() {
		return 3.14 * (radius * radius);
	}
	
	public double getPerimeter() {
		return 3.14 * radius * 2;
	}

	@Override
	public String toString() {

		return "Circle: radius = "+ radius + ", color = " + super.getColor() + ", Area= " + getArea() + ", Perimeter = "+ getPerimeter();
	}
}

class Rectangle  extends Shape{
	
	private double width;
	private double length;
	
	Rectangle(){
		width = 0;
		length = 0;
	}
	
	Rectangle(double w, double l){
		width = w;
		length = l;
	}
	
	Rectangle(double w, double l, String cl){
		width = w;
		length = l;
		super.setColor(cl);
	}
	
	public double getWidth() {
		return width;
	}
	
	public double getLength() {
		return length;
	}
	
	public void setWidth(double w) {
		width = w;
	}
	public void setLength(double l) {
		length = l;
	}
	
	public double getArea() {
		return width * length;
	}
	
	public double getPerimeter() {
		return 2*(width * length);
	}
	
	@Override
	public String toString() {
		return "Rectangle: width= "+ width+ ", length = "+length+", color = "+super.getColor()+", Area = "+getArea()+" Perimeter = "+getPerimeter();
	}
	
}

class Square extends Shape{
	
	Circle c = new Circle();
	Rectangle r = new Rectangle();
		
	Square(){
		c = new Circle();
		r = new Rectangle();
	}
	
	Square(double side){
		c.setRadius(side);
	}
	
	Square(double side, String color){
		c.setRadius(side);
		c.setColor(color);
	}
	
	double getSide() {
		return c.getRadius();
	}
	
	public void setWidth(double w) {
		r.setWidth(w);
	}

	public void setLength(double l) {
		r.setLength(l);
	}
	
	public double getArea() {
		return c.getArea();
	}
	
	public double getPerimeter() {
		return c.getPerimeter();
	}
	
	public void setRadius(double side) {
		c.setRadius(side);
	}
	
	@Override
	public String toString() {
		return "Square: side= "+c.getRadius()+", color = "+super.getColor()+", Area = "+getArea()+", Perimeter = "+getPerimeter();
	}
}

public class Prac2 {

	public static void main(String[] args) {
		Rectangle r = new Rectangle(3, 5, "Red");
		System.out.println(r.toString());
		
		Circle c = new Circle(15);
		System.out.println(c.toString());
		
		Square s = new Square(15, "Purple");
		System.out.println(s.toString());
		
	}

}
