package Clases;

public class Controlador {

	public void menu()
	{int opcion=0;
	 Catalogo catalogo = new Catalogo();
     Vista vista=new Vista();		  
	 do {
		     opcion = vista.elegirOpcion("Añade Obra", "Busca Obra", "Elimina Obra", "Superficie pinturas", "Escultura mas alta", "Mostrar obras");
		 
			   switch (opcion) 
			    {
			   
			   
				case 1: Obra obra = vista.leerObra(); 
					   catalogo.aniadeObra(obra); 	
						break;
						
				case 2:catalogo.buscaObra(vista.pedirNumInventario());
						break;
						
				case 3:catalogo.eliminaObra(vista.pedirNumInventario());
						break;
						
				case 4: catalogo.superficie();
						break;
						
				case 5:catalogo.masAlta();
						break;
						
				case 6:vista.mostrar(catalogo);
					    break;					
					
				} 	   
			  	  			  
			  
		  }while (opcion!=7);
		
		
		
	}
	
}
