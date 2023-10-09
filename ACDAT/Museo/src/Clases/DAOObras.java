package Clases;

import java.util.ArrayList;

public class DAOObras {

	private static DAOObras DAO=null;
	private ArrayList<Obra> obras;
	
	private DAOObras()
	{
		obras = new ArrayList<Obra>();
		Artista artista = new Artista("Manolo","Sanlúcar","22 de septiembre de 1977","N/A");
		obras.add(new Pintura("El salto del atún", 1, artista, 1998, 25.9, 14.5, "Lienzo"));
		obras.add(new Escultura("Cabeza azul", 3, artista, 2008, "Hormigón", 415));
		
	}
	
	public static DAOObras getInstance() {
		if (DAO == null) DAO = new DAOObras();
		
		return DAO;
	}
	
	public ArrayList<Obra> getObras()
	{
		// Acceder a la BD y hacer un select * de obras y retornarlas en una lista
		return obras;
	}

}
