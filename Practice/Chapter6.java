public class Chapter6 {
	
	static int countDown(int n){
		System.out.println(n);
		if (n <= 0) return 1;
		return countDown(n-1);
	}
	
	static int pow(int a, int n) {

		if (n <= 0) return 1;
		return a * pow(a, n-1);
	}
	
	static int arithmetic_series(int a, int b, int n) {
		if (n <= 0) return 0;
		if (a == 1) {
			return n + arithmetic_series(a+1, b, n-1);
		}
		return (n+b)+ arithmetic_series(a+1, b, n-1);
	}
	
	static String digitToWords(int number) {
		if (number <= 0) return "";
		String convert = "";
		int tmp = number % 10;
		if (tmp == 1) {
			convert = "One";
		} else if (tmp == 2) {
			convert = "Two";
		} else if (tmp == 3) {
			convert = "Three";
		} else if (tmp == 4) {
			convert = "Four";
		} else if (tmp == 5) {
			convert = "Five";
		} else if (tmp == 6) {
			convert = "Six";
		} else if (tmp == 7) {
			convert = "Seven";
		} else if (tmp == 8) {
			convert = "Eight";
		} else if (tmp == 9) {
			convert = "Nine";
		}
		return convert+"," + digitToWords(number / 10);
	}

	public static void main(String[] args) {
		String str = "";
		String[] ar = {};
		str = digitToWords(35746);
		ar = str.split(",");
		for (int i = ar.length-1; i>=0; i--) {
			System.out.print(ar[i]+" ");
		}

	}

}
