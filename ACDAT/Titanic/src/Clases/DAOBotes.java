package Clases;

import java.util.Random;
import java.util.TreeMap;

public class DAOBotes {
	private static DAOBotes dao = null;
	private TreeMap <Botes,Botes> botes = new TreeMap <Botes,Botes>();
	
	private DAOBotes (){
		Botes bote;
		
		for(int i=0; i<10; i++) {
			bote = new Botes(numPlazasAleatorio(), obtenerZonaAleatorio());
			botes.put(bote, bote);
		}
	}
	
	private static int numPlazasAleatorio() {
        Random random = new Random();
        return random.nextInt(11) + 20;
    }
	
	private static Zona obtenerZonaAleatorio() {
        Zona[] zonas = Zona.values();
        Random random = new Random();
        int indiceAleatorio = random.nextInt(zonas.length);
        return zonas[indiceAleatorio];
    }
}
