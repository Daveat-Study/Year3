
public class exercise4 {

	public static void main(String[] args) {

		
		//1
//		for(int i = 0; i< 10; i++) {
//			for (int j = 0; j < 9; j ++) {
//				System.out.print("-\t");
//			}
//			System.out.println("\n");
//		}
		
		//2
//		int[] arr_int = {1789, 2035, 1899, 1456, 2013, 1458, 2458, 1254, 1472, 2365, 1456, 2265, 1457, 2456};
//		int input= 1000;
//		int i = 0;
//		for(; i< arr_int.length; i++) {
//			if (arr_int[i] == input) {
//				System.out.println("Found in array");
//				break;
//			}
//		}
//		if (i == arr_int.length) System.out.println("Not Found in array");
		
		//3
//		int[] arr_int = {25, 14, 56, 15, 36, 57, 77, 18, 29, 49};
//		int input= 14;
//		
//		for(int i = 0; i< arr_int.length; i++) {
//			if (arr_int[i] == input) {
//				System.out.println("index number "+ arr_int[i] + " is " +i);
//				break;
//			}
//		}
		
		//4
//		int[] old_arr = {25, 14, 56, 15, 36, 57, 77, 18, 29, 49};
//		int[] new_arr = new int[10];
//		new_arr = old_arr;
//
//		System.out.print("old_arr = [");
//		for(int i = 0; i< old_arr.length; i++) {
//			System.out.print(old_arr[i]);
//			System.out.print(+ i == old_arr.length -1 ? "" : ", ");
//		}
//		System.out.print("]");
//		
//		System.out.print("\nnew_arr = [");
//		for(int i = 0; i< new_arr.length; i++) {
//			System.out.print(new_arr[i]);
//			System.out.print(+ i == new_arr.length -1 ? "" : ", ");
//		}
//		System.out.print("]");
		
		//5
		int[] array_nums = {5, 7, 2, 4, 9};
		int less = array_nums[0];
		int big = array_nums[0];
		
		for (int arr : array_nums) {
			if (arr > big) {
				big = arr;
			} 
			if (arr < less) {
				less = arr;
			}
		}
		System.out.println("The biggest number in array_nums is "+big);
		System.out.println("The smallest number in array_nums is "+less);
		System.out.println("The different between biggest and smallest number is "+(big-less));
		
		//6
//		int[] array_nums = {10789, 2035, 1899, 1456, 2013, 1458, 2458, 1254, 1472, 2365, 1456, 2165, 1457, 2456};
//		int second = array_nums[1];
//		
//		for (int i = 1; i < array_nums.length; i++) {
//			if (array_nums[i] > second) {
//				second = array_nums[i];
//			}
//		}
//		System.out.println("The First biggest number is "+array_nums[0]);
//		System.out.println("The Second biggest number is "+second);
	
		//7
		int[] num = {2,5,5,-1,-3,0,1};
		int sum = 0;
		
		for(int i : num) {
			if (i == 0) break;
			if (i> 0) {
				
				sum += i;
			}
		}
		
		System.out.println("Total sum in num is "+sum);
	}

}
