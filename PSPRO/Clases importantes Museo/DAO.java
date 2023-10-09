import java.time.LocalDate;
import java.util.ArrayList;

public class DAO {

	public static ArrayList<Obra> getObras()
	{ArrayList<Obra> catalogo = new ArrayList<Obra>();
	 
    Autor autor = new Autor ("Felipe","Jerez", LocalDate.of(2000, 2, 4),null);
		Obra pintura = new Pintura(autor,1,2010,"Manchas",40,40,"Papel");
		catalogo.add(pintura);
		
		 autor = new Autor ("Adrían","Arcos", LocalDate.of(1980, 1, 4),null);
		pintura = new Pintura(autor,2,2010,"Manchas",40,40,"Papel");
		catalogo.add(pintura);
		
		return catalogo;
	}
	
}
