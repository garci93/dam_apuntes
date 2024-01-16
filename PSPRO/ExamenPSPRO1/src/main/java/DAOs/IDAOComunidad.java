package DAOs;


import java.util.List;

import POJOs.Comunidad;

public interface IDAOComunidad 
{
    //public Comunidad getComunidad(String codigo);
    public  List<Comunidad> getComunidades();

    public void eliminarComunidad(String codigo);
}
