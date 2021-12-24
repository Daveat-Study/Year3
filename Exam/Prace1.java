class TestTime{
	private int hour = 0;
	private int minute = 0;
	private int second = 0;
	
	TestTime(int h, int m, int s){
		hour = h;
		minute = m;
		second = s;
	}
	
	// Getter
	int getHour () {
		return hour;
	}
	int getMinute () {
		return minute;
	}
	int getSecond () {
		return second;
	}
	
	// Setter
	void setHour(int h) {
		hour = validateHour(h);
	}
	void setMinute(int m) {
		minute = validateMinute(m);
	}
	void setSecond(int s) {
		second = validateSecond(s);
	}
	
	void nextTenSecond() {
		second += 10;
		if (second >= 60) {
			if (second % 10 == 0) {
				second = 0;	
			} else {
				second = second % 10;
			}
			minute +=1;
		}
		if (minute >= 60) {
			minute = 0;
			hour +=1;
		}
		if (hour >= 24) {
			hour = 0;
		}
	}
	
	@Override
	public String toString() {
		return hour+":"+minute+":"+second;
	}
	
	// Error Handler
	int validateHour(int h) {
		if (h >=0 && h <= 23) return h;
		else {
			System.out.println("Invalid hour");
			return 1;
		}
	}
	int validateMinute(int m) {
		if (m >=0 && m <= 59) return m;
		else {
			System.out.println("Invalid Minute");
			return 1;
		}
	}
	int validateSecond(int s) {
		if (s >=0 && s <= 59) return s;
		else {
			System.out.println("Invalid Second");
			return 1;
		}
	}
}


public class Prace1 {

	public static void main(String[] args) {
		TestTime tt = new TestTime(23, 59, 50);
		System.out.println(tt.toString());
		tt.nextTenSecond();
		System.out.println(tt.toString());

	}

}
