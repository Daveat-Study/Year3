class Circle {
		
		private double radius;
		private String color;
		
		Circle(){
			radius = 1.0;
			color = "red";
		}
		
		Circle(double r){
			radius = r;
		}
		
		// Set
//		public void setRadius(double r) {
//			radius = r;
//		}
//		
//		public void setColor(String str) {
//			color = str;
//		}
		
		// Get
		public double getRadius() {
			return radius;
		}
		
		public String getColor() {
			// Formula: (A = π r²)
			return color; 	
		}
		
		public double getArea() {
			// Formula: (A = π r²)
			return 3.14 * ( radius * 2 ); 	
		}
		
		public String toString() {
			return "Circle: radius="+radius+" Color="+color;
		}
	}
	
class Cylinder extends Circle{
	
	private double height;
	
	Cylinder(){
		height = 1.0;
	}
	
	Cylinder(double r){
		super(r);
	}
	
	Cylinder(double r, double h){
		super(r);
		height = h;
	}
	
	// Get
	public double getHeight() {
		return height;
	}
	
	public double getVolume() {
		// Formula: (A = π r²)
		return super.getArea() * height; 	
	}
	
	@Override
	public String toString() {
		return "Cylinder: subclass of "+super.toString()+" Height="+height;
	}
}

public class Homework1 {
	public static void main(String[] args) {
		
		Cylinder c = new Cylinder();

		
//		Circle c = new Circle();
//		
//		System.out.println(c.getArea());
//
		System.out.println(c.toString());

	}
}
