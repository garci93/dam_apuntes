import java.time.LocalDate;
import java.util.Scanner;

public class Vista {

	// escribir las opciones y devolver la opci�n elegida
	public int elegirOpcion(String ... opciones) {
		int ind,opcion=0;
		Scanner scanner = new Scanner (System.in);
		
		for ( ind=0; ind<opciones.length; ind++)
			System.out.println((ind+1) +" - " + opciones[ind]);
		
		System.out.println((ind+1) +" - Salir");
		
		System.out.println("\n\n Elija opcion: ");
		
		do{
			opcion = scanner.nextInt();
			
			
		}while(opcion>opciones.length);
		
		return opcion;
	}

	public void mostrar(GestionCat�logo catalogo) {
		System.out.println(catalogo);
		
	}

	public Obra leerObra() {
		
		
		Autor autor = new Autor ("Santiago","C�ceres", LocalDate.of(1987, 1, 4),null);
		Obra pintura = new Pintura(autor,3,2010,"L�neas",40,40,"Papel");
		
		return pintura;
	}

	public int pedirNumInentario() {
		
		Scanner scanner = new Scanner (System.in);
		System.out.println("Introduzca n�mero de inventario");
		return scanner.nextInt();
	}
	
	
	

}
