package DAM.abstracta.vista;

import DAM.abstracta.POJO.Inmueble;

import java.util.ArrayList;
import java.util.Scanner;

public class IUConsola {
	private Scanner scanner;

	public IUConsola() {
		this.scanner = new Scanner(System.in);
	}
	
	//todo
	public void mostrarLista (ArrayList<Inmueble> inmuebles) {
	}
	
	//todo
	public int dibujarMenu() {
		int opcion;
        Scanner sc = new Scanner(System.in);
        System.out.println("1.Mostrar los inmuebles con un precio de venta inferior al paremtro."+"\n"+
                            "2.Mostrar los locales comerciales de segunda mano con una superficie superior al par metro."+"\n"+
                            "3.Mostrar numero solares no urbanos a la venta."+"\n"+
                            "4.Salir.");
        opcion = sc.nextInt();
        return opcion;
	}
	
	//todo
	public void obtenerPrecioMinimo(ArrayList<Inmueble> inmueblesVenta) {
		
	}
	
	public void mostrarMensaje(String mensaje) {
		
	}
	
	//estas son

    public float precioUsuario() {
        Scanner sc = new Scanner(System.in);
        float precio;
        System.out.println("Introduzca el precio: ");
        precio = sc.nextFloat();
        return precio;
    }
}
