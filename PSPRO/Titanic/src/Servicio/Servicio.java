package Servicio;

import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Random;
import java.util.TreeMap;

import Clases.Botes;
import Clases.DAOBotes;
import Clases.DAOPersonas;
import Clases.Persona;
import Clases.Zona;

public class Servicio {

	private static Servicio servicio = null;
	
	private LinkedHashMap<Persona, Persona> personas;
	
	private LinkedHashMap<Botes, Botes> botes;
	
	private LinkedHashMap<Botes, LinkedHashMap<Persona, Persona>> personaBote;
	
	public Servicio() {
		personas = DAOPersonas.getInstance().getPersonas();
		botes = DAOBotes.getInstance().getBotes();
		
		personaBote = new LinkedHashMap<Botes, LinkedHashMap<Persona, Persona>>();
	}

	
	public LinkedHashMap<Botes, LinkedHashMap<Persona, Persona>> getPersonasBotes() {
		return personaBote;
	}
	
	
	public void asignarPersonasBote() {
		
		personas = ordenarPaisNombre();
		
		/*
		//Mostrar PERSONAS
		int k= 1;
		Iterator<Map.Entry<Persona, Persona>> iteratorP = personas.entrySet().iterator();
		while(iteratorP.hasNext()) {
            Map.Entry<Persona, Persona> personaEntry = iteratorP.next();
            Persona personaKey = personaEntry.getKey();
            Persona personaValue = personaEntry.getValue();
            
            System.out.print(personaKey.getClass() + "-" + personaKey.getDni() + "-" + personaKey.getNombre() + "-" + personaKey.getPais() + "-" + personaKey.getFechaNacimiento() + "-" + personaKey.getTipoPersona() + "-" + personaKey.getZona() + "-" + personaKey.isMinusvalia() 
            + "\n" + personaValue.getClass() + "-" + personaValue.getDni() + "-" + personaValue.getNombre() + "-" + personaValue.getPais() + "-" + personaValue.getFechaNacimiento() + "-" + personaValue.getTipoPersona() + "-" + personaValue.getZona() + "-" + personaValue.isMinusvalia() + "\n");
            k++;
            System.out.println("\n");
		}
		*/
		
		//Mostrar BOTES
		/*
        Iterator<Map.Entry<Bote, Bote>> it = botes.entrySet().iterator();
		while(it.hasNext()) {
            Map.Entry<Bote, Bote> boteEntry = it.next();
            Bote boteKey = boteEntry.getKey();
            Bote boteValue = boteEntry.getValue();
            
            System.out.println(boteKey.getId() + "-" + boteKey.getZona() + "-" + boteKey.getNumPlazas() + 
            		"\n" + boteValue.getId() + "-" + boteValue.getZona() + "-" + boteValue.getNumPlazas());
		}
		*/
		
		//Asignacion por cada Zona
		Zona[] zonas = Zona.values();
		
		for(int i = 0; i<zonas.length; i++) {
    		//Itero Botes
	        Iterator<Map.Entry<Botes, Botes>> iteratorBote = botes.entrySet().iterator();
			while(iteratorBote.hasNext()) {
	            Map.Entry<Botes, Botes> boteEntry = iteratorBote.next();
	            Botes boteKey = boteEntry.getKey();
	            Botes boteValue = boteEntry.getValue();
	            
	            //Encuentra un bote de la zona[i]
	            if(boteKey.getZona().equals(zonas[i])) {
	            	
	            	LinkedHashMap<Persona, Persona> zonaPersonas = new LinkedHashMap<Persona, Persona>();
	            	
					//Itero Personas
		            Iterator<Map.Entry<Persona, Persona>> iteratorPersona = personas.entrySet().iterator();
		    		while(iteratorPersona.hasNext()) {
		                Map.Entry<Persona, Persona> personaEntry = iteratorPersona.next();
		                Persona personaKey = personaEntry.getKey();
		                Persona personaValue = personaEntry.getValue();
		                
		                //Encuentra las personas de la zona[i] y se guardan en el bote sin superar el numero de plazas
			            if(personaKey.getZona().equals(zonas[i]) && zonaPersonas.size() < boteKey.getNumPlazas()) {
			            	zonaPersonas.put(personaKey, personaValue);
			            	iteratorPersona.remove();
			            }
		    		}
		            //Guardo el bote y las personas de la zona[i]
		            personaBote.put(boteKey, zonaPersonas);
	            	
	            }
	            
			}
			
		}

	}
	
	
	private LinkedHashMap<Persona, Persona> ordenarPaisNombre() {
        // Ordenar el LinkedHashMap por claves usando TreeMap
        TreeMap<Persona, Persona> ordenadoPorClaves = new TreeMap<>(personas);

        // Crear un nuevo LinkedHashMap a partir del TreeMap ordenado
        LinkedHashMap<Persona, Persona> personas = new LinkedHashMap<>(ordenadoPorClaves);
        
        return personas;
	}

	
	
	public static Servicio getInstance() {
		if(servicio == null) {
			return new Servicio();
		}
		return servicio;
	}
	
	
	
	
}