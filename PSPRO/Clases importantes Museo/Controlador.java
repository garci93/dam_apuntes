
public class Controlador {

	public void menu()
	{int opcion=0;
	 GestionCatálogo catalogo = new GestionCatálogo();
     Vista vista=new Vista();		  
	 do {
		     opcion = vista.elegirOpcion("Añade Obra", "Elimina Obra","Busca Obra"
		     		, "Supercie pinturas", "Escultura más alta","Mostrar obras");
		 
			   switch (opcion) 
			    {
			   
			   
				case 1: Obra obra = vista.leerObra(); 
					   catalogo.añadeObra(obra); 
						break;
						
				case 2:catalogo.buscaObra(vista.pedirNumInentario());
						break;
						
				case 3:catalogo.eliminarObra(vista.pedirNumInentario());
						break;
						
				case 4: catalogo.sumaSuperficiePinturas();
						break;
						
				case 5:catalogo.masAlta();
						break;
						
				case 6:vista.mostrar(catalogo);
					    break;					
					
				} 	   
			  	  			  
			  
		  }while (opcion!=6);
		
		
		
	}
	
}
