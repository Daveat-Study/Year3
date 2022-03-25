import java.awt.*;

import javax.swing.ImageIcon;
import javax.swing.JFrame;

public class Test1 {

	JFrame f;
	
	public Test1() {

		f = new JFrame("Demo Swing");
		f.setSize(400, 400);
		f.setLayout(new FlowLayout());
		f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		f.getContentPane().setBackground(Color.red);
		ImageIcon icon = new ImageIcon("/Users/mac/Desktop/icons8-loyalty-50.png");
		ImageIcon icons = new ImageIcon(this.getClass().getResource("icon.png"));
		f.setIconImage(icons.getImage());
		f.setVisible(true);
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		new Test1();

	}

}
