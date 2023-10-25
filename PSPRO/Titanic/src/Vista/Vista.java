package Vista;

import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.Map;

import Clases.Botes;
import Clases.Persona;

public class Vista {



    public Vista() {

    }


    public void mostrarDatos(LinkedHashMap<Botes, LinkedHashMap<Persona, Persona>> personaBote) {

        Iterator<Map.Entry<Botes, LinkedHashMap<Persona, Persona>>> i = personaBote.entrySet().iterator();
        while(i.hasNext()) {
            Map.Entry<Botes, LinkedHashMap<Persona, Persona>> pb = i.next();
            Botes bk = pb.getKey();
            HashMap<Persona, Persona> pv = pb.getValue();

            System.out.print(bk.getId() + "-" + bk.getZona() + "-NumPlazas: " + bk.getNumPlazas() + "\n");

            for (Map.Entry<Persona, Persona> personaEntry : pv.entrySet()) {
                Persona personaKey = personaEntry.getKey();
                Persona personaValue = personaEntry.getValue();

                System.out.print(personaKey.getDni() + "-" + personaKey.getZona() + "\n");

            }
            System.out.print("\n");
        }

    }


}
