import javax.swing.*;

import java.awt.Color;
import java.awt.event.*;


public class Test1 {

	static JFrame f = new JFrame("Task 2 Semester 2");
	static JPasswordField tf1 = new JPasswordField();
	static JTextField tf2 = new JTextField();
	static JButton btn = new JButton("Gernerate"), guessBtn = new JButton("Guess");
	static JLabel lb1 = new JLabel("The number is"), lb2 = new JLabel("Enter your guest"), msg = new JLabel(), msg2 = new JLabel();
	
	static void setRandom(int rd) {
		
	}
	
	public static void main(String[] args) {
		
		// For TextField
		tf1.setBounds(150, 50, 120, 30);
		tf1.setEchoChar('*');
		tf1.setEditable(false);
		tf2.setBounds(150, 100, 120, 30);
		f.add(tf1);
		f.add(tf2);
		
		
		// FOr Button
		btn.setBounds(300, 50, 120, 30);
		guessBtn.setBounds(300, 50, 120, 30);
		guessBtn.setBounds(300, 100, 120, 30);
		btn.addActionListener(new ActionListener() {
			// Random Number
			int randomnumber = (int) (( Math.random() * (99-1) ) + 1);
			public void actionPerformed(ActionEvent e){
	            tf1.setText(String.valueOf(randomnumber));  
	        }
		});
		guessBtn.addActionListener(new ActionListener() {
			// Random Number
			public void actionPerformed(ActionEvent e){
				String str = findNumber(tf2.getText(), String.valueOf(tf1.getPassword()));
				if (str != "") {

					msg.setText("WRONG");
					msg.setForeground(Color.red);
					
				} else {

					msg.setText("CORRECT");
					msg.setForeground(Color.green);
					msg2.setText("");
				}
				
				msg2.setText(str);

				
				// For Label
				msg.setBounds(50, 150, 100, 30);
				msg2.setBounds(100, 150, 100, 30);
				
				f.add(msg);
				f.add(msg2);
	        }
		});
		f.add(btn);
		f.add(guessBtn);

		lb1.setBounds(50, 50, 100, 30);
		lb2.setBounds(50, 100, 100, 30);
		f.add(lb1);
		f.add(lb2);
	
		f.setSize(500, 230);
		f.setLayout(null);
		f.setVisible(true);

	}
	
	static String findNumber(String number, String randomNum) {
		System.out.println("findNumber");
		System.out.println(number);
		System.out.println(randomNum);
		int tmp = Integer.parseInt(number);
		
		int tmp2 = Integer.parseInt(randomNum);
		String strTmp = "";
		if (tmp < tmp2) {
			strTmp = "Try Higher than 30";
		} else if (tmp > tmp2){
			strTmp = "Try Lower than 30";
		} else {
			return "";
		}
		
		return strTmp;
	}

}
