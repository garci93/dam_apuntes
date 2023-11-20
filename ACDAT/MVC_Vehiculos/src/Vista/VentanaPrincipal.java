package Vista;
import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JMenuBar;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class VentanaPrincipal extends JFrame implements ActionListener {

	private JPanel panelActivo = null;
	private JMenuItem itemAcerca, itemCRUD, itemSalir;
	private JMenuItem itemJuego;

	

	/**
	 * Create the frame.
	 */
	public VentanaPrincipal() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 615, 404);

		JMenuBar menuBar = new JMenuBar();
		setJMenuBar(menuBar);

		JMenu MenuFile = new JMenu("File");
		menuBar.add(MenuFile);

		itemCRUD = new JMenuItem("CRUD");
		MenuFile.add(itemCRUD);
		itemCRUD.addActionListener(this);
		
		itemJuego = new JMenuItem("Jugar");
		MenuFile.add(itemJuego);
		itemJuego.addActionListener(this);
		
		itemAcerca = new JMenuItem("Acerca de...");

		MenuFile.add(itemAcerca);
		itemAcerca.addActionListener(this);

		itemSalir = new JMenuItem("Salir");
		MenuFile.add(itemSalir);
		itemSalir.addActionListener(this);

		// this.getContentPane().add(new PanelCRUD());

	}

	@Override
	public void actionPerformed(ActionEvent e) {
		
		if (e.getSource()== itemSalir)
			 System.exit(0);
		
		else if (e.getSource()== itemAcerca)
		{  
			//this.getContentPane().removeAll();
			if (panelActivo!=null)
					panelActivo.setVisible(false);
			panelActivo = new PanelAcercaDe();
			panelActivo.setVisible(true);
		   getContentPane().add(panelActivo);
		 
		   this.setVisible(true);
		   
		   }
		else if (e.getSource()== itemCRUD)
		{  System.out.println("llega");
			//this.getContentPane().removeAll();
		if (panelActivo!=null)
				panelActivo.setVisible(false);
			panelActivo = new PanelCRUD();
			panelActivo.setVisible(true);
		   getContentPane().add(panelActivo);
		 
		   this.setVisible(true);
		   
		   }
		else if (e.getSource()== itemJuego)
		{  
			//this.getContentPane().removeAll();
		if (panelActivo!=null)
				panelActivo.setVisible(false);
			panelActivo = new PanelJuego();
			panelActivo.setVisible(true);
		   getContentPane().add(panelActivo);
		 
		   this.setVisible(true);
		   
		   }
		
		
	}

}
