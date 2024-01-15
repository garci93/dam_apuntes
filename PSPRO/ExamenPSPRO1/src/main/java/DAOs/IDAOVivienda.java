package DAOs;


import java.util.List;

import POJOs.Vivienda;

public interface IDAOVivienda 
{
    public int insertarVivienda(Vivienda vivienda);
    public int eliminarVivienda(Vivienda vivienda);
    public Vivienda getVivienda(String codigo);
    public  List<Vivienda> getViviendas();
}
