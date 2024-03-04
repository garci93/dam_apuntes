

import java.awt.geom.*;

import javax.swing.*;



import java.util.*;
import java.awt.*;
import java.awt.event.*;

public class TestPelota {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//JFrame marco=new Ventana();
		
		//marco.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		//marco.setVisible(true);
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Ventana frame = new Ventana();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	}







