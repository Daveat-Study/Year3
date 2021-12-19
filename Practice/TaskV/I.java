import java.time.LocalDate;
import java.time.format.DateTimeFormatter;

class Date {
	
	private int day;
	private int month;
	private int year;
	
	Date(int d, int m, int y){
		if (y > 9999) {
			System.out.println("Invalid year!");
			year = 2020;
		} else {

			year = y;
		}
		
		if (m <= 0) {
			System.out.println("Invalid month!");
			month = 1;
		}
		else if (m > 12) {
			month = 1;
		} else {
			month = m;
		}
		
		if (d <= 0) {
			System.out.println("Invalid day!");
			day = 1;
		}
		else if (d > 31) {

			day = 1;
		} else {
			day = d;
		}
	}
	
	
	// Getter
	int getDay() {
		return day;
	}
	int getMonth() {
		return month;
	}
	int getYear() {
		return year;
	}
	
	// Setter
	void setDay(int d) {
		if (d <= 0) {
			System.out.println("Invalid day!");
			day = 1;
		}
		else if (d > 31) {

			day = 1;
		} else {
			day = d;
		}
	}
	void setMonth(int m) {
		if (m <= 0) {
			System.out.println("Invalid month!");
			month = 1;
		}
		else if (m > 12) {
			month = 1;
		} else {
			month = m;
		}
	}
	void setYear(int y) {
		if (y > 9999) {
			System.out.println("Invalid year!");
			year = 2020;
		} else {

			year = y;
		}
	}
	
	@Override
	public String toString() {
		DateTimeFormatter dateFormat = DateTimeFormatter.ofPattern("dd-MMM-yyyy");
		return dateFormat.format(LocalDate.of(year, month, day)).toString();
	}
}

public class I {

	public static void main(String[] args) {

		Date d = new Date(0, 0, 99999);
		System.out.println(d.toString());
		
		d.setDay(12);
		d.setMonth(2);
		d.setYear(2021);

		System.out.println(d.toString());
	}

}
