package Vista;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import Controller.ControllerJuego;

public class PanelJuego extends JPanel implements ActionListener{
	public JTextField txtRespuesta;
    public JLabel etiSecreta;
    JButton btnNuevoCoche, btnComprobar;
    ControllerJuego conJuego;
	/**
	 * Create the panel.
	 */
	public PanelJuego() {
		conJuego = new ControllerJuego(this);
		
		setLayout(null);
		
		txtRespuesta = new JTextField();
		txtRespuesta.setBounds(77, 122, 137, 20);
		add(txtRespuesta);
		txtRespuesta.setColumns(10);
		
		 etiSecreta = new JLabel("Pulse nuevo para comenzar");
		etiSecreta.setBounds(77, 58, 137, 19);
		add(etiSecreta);
		
		 btnNuevoCoche = new JButton("Pulse nuevo para comenzar");
		btnNuevoCoche.addActionListener(this);
		btnNuevoCoche.setBounds(241, 54, 89, 23);
		add(btnNuevoCoche);
		
		 btnComprobar = new JButton("Comprobar");
		btnComprobar.addActionListener(this);
		btnComprobar.setBounds(241, 121, 89, 23);
		add(btnComprobar);
		
		

	}
	@Override
	public void actionPerformed(ActionEvent e) {
		
		if (e.getSource()== btnNuevoCoche)
		{ conJuego.nuevoCoche();
			
		}
		else if (e.getSource()== btnComprobar) 
		{ conJuego.comprobarCoche();
			
		}
	}
}
