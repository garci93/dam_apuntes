package Clases;

import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Random;
import java.util.TreeMap;

import Clases.Botes;
import Clases.Zona;

public class DAOBotes {

	private static DAOBotes dao = null;
	private LinkedHashMap<Botes, Botes> botes;
	
	private DAOBotes() {
		
		botes = new LinkedHashMap<Botes, Botes>();
		
		Botes bote;
		
		for(int i=0; i<10; i++) {
			bote = new Botes(numPlazasAleatorio(), obtenerZonaAleatorio());
			botes.put(bote, bote);
		}
		
	}
	
	public LinkedHashMap<Botes, Botes> getBotes(){
		return botes;
	}
	
	private Integer numPlazasAleatorio() {
		Random random = new Random();
		Integer numAle = random.nextInt(11) + 10;
		return numAle;
	}
	
	
    private Zona obtenerZonaAleatorio() {
        Zona[] zonas = Zona.values();
        Random random = new Random();
        int indiceAleatorio = random.nextInt(zonas.length);
        return zonas[indiceAleatorio];
    }
	
	public static DAOBotes getInstance() {
		if(dao==null) {
			return new DAOBotes();
		}
		return dao;
	}
	
}