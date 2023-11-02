package DAM.abstracta.controlador;

import java.util.ArrayList;

import DAM.abstracta.POJO.Inmueble;
import DAM.abstracta.interfaces.IControlador;
import DAM.abstracta.modelo.Agencia;
import DAM.abstracta.vista.IUConsola;

public class Controlador implements IControlador {
	private IUConsola vista;
    private Agencia servicio;

	public Controlador() {
		vista = new IUConsola();
        servicio = new Agencia();
	}

	@Override
	public void ejecutar() {
        int opcion;
        do {
            opcion = vista.dibujarMenu();
            float precioUsuario;

            switch(opcion) {

            case 1: precioUsuario = vista.precioUsuario();
                    ArrayList<Inmueble> inmueblesVenta = servicio.inmueblesVenta(precioUsuario);
                    vista.obtenerPrecioMinimo(inmueblesVenta);
                break;

            default: 
                break;
            }
        }while(opcion != 4);
    }
}