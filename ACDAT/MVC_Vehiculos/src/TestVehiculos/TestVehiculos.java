package TestVehiculos;

import java.awt.EventQueue;

import Vista.VentanaPrincipal;
import Vista.VentanaPrincipal;

public class TestVehiculos {

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaPrincipal frame = new VentanaPrincipal();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	

	}

}
