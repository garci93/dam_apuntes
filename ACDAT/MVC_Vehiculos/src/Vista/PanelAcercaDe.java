package Vista;
import javax.swing.JPanel;
import javax.swing.JLabel;
import java.awt.Font;
import java.awt.Color;

public class PanelAcercaDe extends JPanel {

	/**
	 * Create the panel.
	 */
	public PanelAcercaDe() {
		
		JLabel lblNewLabel = new JLabel("Aplicaci\u00F3n con modelo vista y controlador");
		lblNewLabel.setForeground(Color.BLUE);
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 29));
		add(lblNewLabel);

	}

}
