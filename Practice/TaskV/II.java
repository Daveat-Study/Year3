class Person{
	private String name;
	private String address;
	
	Person(String n, String a){
		name = n;
		address = a;
	}
	
	// Getter
	String getName() {
		return name;
	}
	String getAddress() {
		return address;
	}
	
	void setAddress(String adr) {
		address = adr;
	}

	@Override
	public String toString() {
		return "Person [name="+name+", address="+address+"]";
	}
	
}

class Student extends Person{
	
	private String program;
	private int year;
	private double fee;
	
	Student(String n, String a, String pro, int yr, double f){
		super(n, a);
		program = pro;
		year = yr;
		fee = f;
	}
	
	// Getter
	String getProgram() {
		return program;
	}
	int getYear() {
		return year;
	}
	double getFee() {
		return fee;
	}
	
	// Setter
	void setProgram(String pro) {
		program = pro;
	}
	void setYear(int yr) {
		year = yr;
	}
	void setFee(double fe) {
		fee = fe;
	}
	
	@Override
	public String toString() {
		return "Student ["+super.toString()+"], program="+program+", year="+year+", fee="+fee+"]";
	}
	
}

class Staff extends Person{
	private String school;
	private double pay;
	
	Staff(String n, String a, String sc, double pa){
		super(n, a);
		school = sc;
		pay = pa;
	}
	
	// Getter
	String getSchool() {
		return school;
	}
	double getPay() {
		return pay;
	}
	
	// Setter
	void setSchool(String sc) {
		school = sc;
	}
	void setPay(double pa) {
		pay = pa;
	}
	
	@Override
	public String toString() {
		return "Staff ["+super.toString()+"], school="+school+", pay="+pay+"]";
	}
}


public class II {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Student std = new Student("Daveat", "pp", "IT", 1999, 250.0);
		System.out.println(std.toString());
		

		Staff stf = new Staff("Daveat", "pp", "IT", 250.0);
		System.out.println(stf.toString());
	}

}
