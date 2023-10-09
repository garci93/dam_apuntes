import java.time.LocalDate;
import java.util.ArrayList;

public class GestionCatálogo {
      private ArrayList<Obra> catalogo;
      
      
    

	//Constructor con datos y un DAO (capa datos)
      
      public GestionCatálogo() {
    	  
    	  catalogo = DAO.getObras();
    	  
	}

	public boolean añadeObra(Obra obra)
      { boolean esta=catalogo.contains(obra); //buscaObra(obra.getnInventario());
		if (!esta)
    	  catalogo.add(obra);
    	  
    	 return !esta; 
    	  
        //catalogo.contains(obra);
    	 //versión contains con equals
      }
	
      public boolean buscaObra(int nInventario)
      { boolean enc=false;
    	  
    	  for(int ind=0; ind<catalogo.size() && enc==false;ind++)
    	  { Obra obra= catalogo.get(ind);
    		  if (obra.getnInventario()==nInventario )
    		    enc=true;
    		  
    	  }
    	return enc;	  
      }
      
      public Obra buscaObraBis(int nInventario)
      {Obra obra,obraBuscada=null;
    	  
    	  for(int ind=0; ind<catalogo.size() && obraBuscada==null;ind++)
    	  { obra= catalogo.get(ind);
    		  if (obra.getnInventario()==nInventario )
    		    obraBuscada=obra;
    			
    	  }
    	return obraBuscada;	  
      }
     
     
      
	@Override
	public String toString() {
		String cadena="";
		  for(int ind=0; ind<catalogo.size();ind++)
		       cadena += "\n"+ catalogo.get(ind);
		  
		return cadena;
	}
      
	public boolean eliminarObra(int nInventario)
	{ Obra obra = new Obra(nInventario);
		return catalogo.remove(obra);
		
	} 
     
	public int sumaSuperficiePinturas()
	{int suma=0;
	 Pintura pintura;
		for(int ind=0; ind<catalogo.size();ind++)
		  if (catalogo.get(ind) instanceof Pintura)
		  { pintura = (Pintura) catalogo.get(ind);
			suma+= pintura.superficie();
		  }
		
		return suma;
	}
	
	public float masAlta()
	{float alta=0;
	 Escultura escultura;
	 
	for(int ind=0; ind<catalogo.size();ind++)
		  if (catalogo.get(ind) instanceof Escultura)
		     { escultura = (Escultura) catalogo.get(ind);
			  if (escultura.getAltura()<alta)
                   alta = escultura.getAltura();
		     }
		
	 return alta;
	}
}
