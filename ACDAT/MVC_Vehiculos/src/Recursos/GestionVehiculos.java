package Recursos;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

import DAOs.DAOVehiculoImpl;

public class GestionVehiculos {
	
	private ArrayList<Vehiculo> listaVehiculos;
	private String cadena="";
	private Random random;
	
	public GestionVehiculos()
	{listaVehiculos = (ArrayList<Vehiculo>) DAOVehiculoImpl.getInstance().getVehiculos();
    random = new Random();
	
		
	}
	
	public String getVehiculo()
	{  String cadenaEspacios="";
		Collections.shuffle(listaVehiculos);
	   cadena = listaVehiculos.get(0).getMarca() + " " + listaVehiculos.get(0).getModelo();
		for (int cont=0; cont<cadena.length(); cont++)
		{ if (random.nextBoolean())  cadenaEspacios = cadenaEspacios + cadena.charAt(cont);
		else  cadenaEspacios = cadenaEspacios +  "_";
		}
		
		
		return cadenaEspacios;
	}
	
	public boolean compara(String cadenaJugador)
	{return cadena.equalsIgnoreCase(cadenaJugador);
		}

}
