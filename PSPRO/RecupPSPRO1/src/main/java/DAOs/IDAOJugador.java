package DAOs;


import java.util.List;

import POJOs.Jugador;
import java.util.ArrayList;

public interface IDAOJugador 
{
    public  List<Jugador> getJugadores();
    
    public ArrayList<String> historial = new ArrayList<String>();
}
