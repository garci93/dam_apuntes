package DAM.abstracta.controlador;

import DAM.abstracta.interfaces.IControlador;
import DAM.abstracta.modelo.Agencia;
import DAM.abstracta.vista.IUConsola;

public class Controlador implements IControlador {
	private IUConsola vista;
    private Agencia servicio;

	public Controlador() {
		vista = new IUConsola();
        servicio = new Agencia();
		// TODO Auto-generated constructor stub
        
        //CONSULTAR REFERENCIAS,
	}

	@Override
	public void ejecutar() {
		// TODO Auto-generated method stub
		
	}
	
}
