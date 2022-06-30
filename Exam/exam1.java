import javax.swing.*;
import java.awt.event.*;


public class exam1 {

	static JFrame f = new JFrame("Excercise 1");
	static JTextField tf1 = new JTextField();
	static JTextField tf2 = new JTextField();
	static JTextField tf3 = new JTextField();
	static JButton addBtn = new JButton("Add"), clearBtn = new JButton("Clear");
	static JLabel lb1 = new JLabel("First Number"), lb2 = new JLabel("Second Number"), lb3 = new JLabel("Result"), msg = new JLabel();
	
	static void setRandom(int rd) {
		
	}
	
	public static void main(String[] args) {
		
		// For TextField
		tf1.setBounds(150, 50, 120, 30);
		tf2.setBounds(150, 100, 120, 30);
		tf3.setBounds(150, 150, 120, 30);
		tf3.setEditable(false);
		f.add(tf1);
		f.add(tf2);
		f.add(tf3);
		
		
		// FOr Button
		addBtn.setBounds(30, 200, 120, 30);
		clearBtn.setBounds(150, 200, 120, 30);
		
		addBtn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e){
				int n1 = Integer.parseInt(String.valueOf(tf1.getText()));
				System.out.print(n1);
				int n2 = Integer.parseInt(String.valueOf(tf2.getText()));
				System.out.print(n2);
				int sum = n1 + n2;

				System.out.print(sum);
				tf3.setText(String.valueOf(sum));
	        }
		});
		
		clearBtn.addActionListener(new ActionListener() {
			// Random Number
			public void actionPerformed(ActionEvent e){
				tf1.setText("");
				tf2.setText("");
				tf3.setText("");
	        }
		});

		lb1.setBounds(50, 50, 100, 30);
		lb2.setBounds(50, 100, 100, 30);
		lb3.setBounds(50, 150, 100, 30);
		
		f.add(lb1);
		f.add(lb2);
		f.add(lb3);
		f.add(addBtn);
		f.add(clearBtn);
	
		f.setSize(350, 300);
		f.setLayout(null);
		f.setVisible(true);

	}
	

}