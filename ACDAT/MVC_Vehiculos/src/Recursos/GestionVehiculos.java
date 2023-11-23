package Recursos;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

import DAOs.DAOClienteImpl;

public class GestionClientes {
	
	private ArrayList<Cliente> listaClientes;
	private String cadena="";
	private Random random;
	
	public GestionClientes()
	{listaClientes = (ArrayList<Cliente>) DAOClienteImpl.getInstance().getClientes();
    random = new Random();
	
		
	}
	
	public String getCliente()
	{  String cadenaEspacios="";
		Collections.shuffle(listaClientes);
	   cadena = listaClientes.get(0).getMarca() + " " + listaClientes.get(0).getModelo();
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
