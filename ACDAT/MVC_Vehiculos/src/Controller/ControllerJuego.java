package Controller;


import javax.swing.JOptionPane;
import Recursos.GestionClientes;
import Vista.PanelJuego;

public class ControllerJuego{
	
	private GestionClientes gestionClientes;
	
	private PanelJuego panelJuego;
	
	public ControllerJuego(PanelJuego panelJuego) 
	{
		
		gestionClientes = new GestionClientes();
		this.panelJuego= panelJuego;
	}

	public  void nuevoCoche()
	{ panelJuego.etiSecreta.setText(gestionClientes.getCliente());
		
	}
	
	public  void comprobarCoche()
	{ String palabra =  panelJuego.txtRespuesta.getText().toString();
		if (gestionClientes.compara(palabra)) 
			JOptionPane.showMessageDialog(panelJuego, "Correcto");
		else JOptionPane.showMessageDialog(panelJuego, "Incorrecto");
		
	}

}
