import java.sql.Connection;
import java.sql.DriverManager;

public class mySQL_demo {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try {

			//1. Register Driver Class
			Class.forName("com.mysql.jdbc.Driver"); // From JDK 6 It will be automatic add driver name when we delcare url connection
			Connection con = null;
			
			String url = "jdbc:mysql://localhost:3306/sys";
			String usr = "root";
			String pass = "Selendra";
			
			try {

				con = DriverManager.getConnection(url, usr, pass);
			} catch (Exception e) {
				e.printStackTrace();
			}
			
			if (con != null) {
				System.out.println("Done connected");
			} else {
				System.out.println("Not done");
			}
			
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}

}
