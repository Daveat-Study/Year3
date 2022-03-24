import java.awt.*;
import javax.swing.JFrame;

public class Test1 {

	JFrame f;
	
	public Test1() {
		f = new JFrame("Demo Swing");
		f.setSize(400, 400);
		f.setLayout(new FlowLayout());
		f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		f.getContentPane().setBackground(Color.red);
		f.setVisible(true);
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		new Test1();

	}

}
