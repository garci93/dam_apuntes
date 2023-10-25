package Clases;

import java.util.Date;
import java.util.LinkedHashMap;
import java.util.Random;
import java.util.TreeMap;

public class DAOPersonas {
	private static DAOPersonas dao = null;
	private LinkedHashMap<Persona, Persona> personas = new LinkedHashMap<Persona, Persona>();
	
	private DAOPersonas(){

		Pasajero pasajero;
		Tripulacion tripulante;
		
		for(int i=0; i<15; i++) {
			pasajero = new Pasajero(generarDNI(), obtenerPaisAleatorio(), obtenerZonaAleatorio(), generarNombreAleatorio(), minusvaliaAleatorio(), fechaAleatoria(), obtenerTipoPersonaAleatorio(), i);
			personas.put(pasajero, pasajero);
		}
		
		for(int i=0; i<10; i++) {
			tripulante = new Tripulacion(generarDNI(), obtenerPaisAleatorio(), obtenerZonaAleatorio(), generarNombreAleatorio(), minusvaliaAleatorio(), fechaAleatoria(), obtenerTipoPersonaAleatorio(), responsabilidadAleatorio());
			personas.put(tripulante, tripulante);
		}
		
	}
	
	private static String generarDNI() {
        Random random = new Random();
        String letras = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        String cadenaNum = "";
        int aleatorio, letraAleatorio;
        for(int i=0; i<8; i++) {
        	aleatorio = random.nextInt(9);
        	cadenaNum += ""+ aleatorio;
        }
        letraAleatorio = random.nextInt(letras.length());
        cadenaNum += letras.charAt(letraAleatorio);
        return cadenaNum;
    }
	
    private static Pais obtenerPaisAleatorio() {
        Pais[] paises = Pais.values();
        Random random = new Random();
        int indiceAleatorio = random.nextInt(paises.length);
        return paises[indiceAleatorio];
    }
    
    private static Zona obtenerZonaAleatorio() {
        Zona[] zonas = Zona.values();
        Random random = new Random();
        int indiceAleatorio = random.nextInt(zonas.length);
        return zonas[indiceAleatorio];
    }
    
    private static String generarNombreAleatorio() {
        String[] nombres = { "Manuel", "Anna", "Sarah", "Fabrizio", "Ian", "Leigh", "Francesco", "Luisa", "Jacob", "Nicole" };
        Random random = new Random();
        String nombre = nombres[random.nextInt(nombres.length)];

        return nombre;
    }
    
    private static Minusvalia minusvaliaAleatorio() {
    	Minusvalia[] minusvalias = Minusvalia.values();
        Random random = new Random();
        int indiceAleatorio = random.nextInt(minusvalias.length);
        return minusvalias[indiceAleatorio];
    }
	
    private static Date fechaAleatoria() {
        Random random = new Random();
        
        long milisegundosAleatorios = random.nextLong();
        
        long rangoDeAnios = 10;
        long milisegundosEnUnAnio = 365L * 24 * 60 * 60 * 1000;
        long milisegundosEnElPasado = milisegundosAleatorios % (rangoDeAnios * milisegundosEnUnAnio);
        
        long tiempoActual = System.currentTimeMillis();
        long milisegundosFechaAleatoria = tiempoActual - milisegundosEnElPasado;
        
        Date fechaAleatoria = new Date(milisegundosFechaAleatoria);
        
        return fechaAleatoria;
    }
    
    private static TipoPersona obtenerTipoPersonaAleatorio() {
    	TipoPersona[] tipoPersona = TipoPersona.values();
        Random random = new Random();
        int indiceAleatorio = random.nextInt(tipoPersona.length);
        return tipoPersona[indiceAleatorio];
    }
    
    private static Responsabilidad responsabilidadAleatorio() {
    	Responsabilidad[] responsabilidades = Responsabilidad.values();
        Random random = new Random();
        int indiceAleatorio = random.nextInt(responsabilidades.length);
        return responsabilidades[indiceAleatorio];
    }
    
	public static DAOPersonas getInstance() {
		if(dao == null) {
			return new DAOPersonas();
		}
		return dao;
	}
	
	public LinkedHashMap<Persona, Persona> getPersonas(){
        return personas;
    }
}
