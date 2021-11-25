import java.math.BigDecimal;

public class test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
//		short i = 4;
//		int i2 = 4;
//		if (i != i2) {
//			System.out.println("H");
//		} else {
//			System.out.println("K");
//		}
		
//		int i2 = 5;
//	      int i3 = 10;
//	      if(i2 != i3) {
//	         System.out.print("T");
//	      }
//	      if(i3 == 15) {
//	         System.out.print("Y");
//	      }
//	      else {
//	         System.out.print("Z");
//	      }
		
		// 6
//		int a = 23;
//		int b = 10;
//		int c = 20;
//		
//		if (a > b && a > c) {
//			System.out.println(a);
//		} else if (b > a&& b >c){
//			System.out.println(c);	
//		} else {
//			System.out.println(c);
//		}
//		int a = 1;
//		if (a < 0) {
//			System.out.println("Negative");
//		} else if(a > 0) {
//			System.out.println("Positive");
//		}
		
		// 7
//		int a = 2;
//		if (a == 1) {
//			System.out.println("January 30");
//		} else if (a == 2) {
//			if (a % 4 == 0) {
//				System.out.println("Febuary 29");
//			} else {
//				System.out.println("Febuary 28");
//			}
//		} else if (a == 3) {
//			System.out.println("March 31");
//		} else if (a == 4) {
//			System.out.println("April 30");
//		} else if (a == 5) {
//			System.out.println("May 31");
//		} else if (a == 6) {
//			System.out.println("June 30");
//		} else if (a == 7) {
//			System.out.println("July 31");
//		} else if (a == 8) {
//			System.out.println("August 31");
//		} else if (a == 9) {
//			System.out.println("September 30");
//		} else if (a == 10) {
//			System.out.println("October 31");
//		} else if (a == 11) {
//			System.out.println("November 30");
//		} else if (a == 12) {
//			System.out.println("December 31");
//		}
		
		//8
//		int a = 2;
//		int b = 3;
//		int c = 4;
//		
//		if (a==b && b==c && a==c) {
//			System.out.println("All numbers are equal");
//		} else if ((a!=b && b!=c && a!=c)) {
//			System.out.println("All numbers are different");
//		} else {
//			System.out.println("Neither all are equal or different");
//		}
		
		//9
		BigDecimal money = new BigDecimal(120);
		int score = 8;
		if (score >= 8) {
			money = money.add(new BigDecimal(50));
		} 
		if (score > 6) {
			money = money.add(new BigDecimal(20));
		}

		System.out.println(money);

		//10
//		int a;
//		a = 10;
//		System.out.println(++a + ++a);
	}

}
