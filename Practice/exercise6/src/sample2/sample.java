package sample2;

public class sample {

	public static void main(String[] args) {
		for (int i = 0; i < 15; i++) {
			if (i < 9) {
				if (i % 2 == 0) {
					System.out.print("* * * * * * *");
				} else {
					System.out.print(" * * * * * * ");
				}
				for (int j = 0; j < 5; j++) {
					System.out.print("=============");
				}
			} else {
				for (int j = 0; j < 6; j++) {
					System.out.print("=============");
				}
			}
			System.out.println();
		}
	}

}
