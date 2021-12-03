package students;

public class students {

	
	String name;
	int age;
	String major;
	double score;
	
	students(String string, int a, String string2, double s){
		name = string;
		age = a;
		major = string2;
		score = s;
	}
	
	// Behavior
	String getName() {
		return name;
	}
	String getMajor() {
		return major;
	}
	double getScore() {
		return score;
	}
	void showResult() {
		System.out.println("Student name: "+name);
		System.out.println("Student age: "+age);
		System.out.println("Student major: "+major);
		System.out.println("Student score: "+score);
	}
	
	public static void main(String[] args) {
		students std = new students("Daveat", 22, "Computer Science", 49.9);
		System.out.println(std.name);
	}
}
