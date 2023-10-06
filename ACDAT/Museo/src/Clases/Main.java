package Clases;

public class Main {
	public static void main(String[] args) { 
		Catalogo c = new Catalogo();
		Artista a1 = new Artista("Manolo","Sanlúcar","22 de septiembre de 1977","N/A");
		Artista a2 = new Artista("Carmela","Toledo","13 de abril de 1962","1 de julio de 2012");
		Artista a3 = new Artista("Giovanni","Sicilia","9 de marzo de 1599","8 de octubre de 1654");
		Pintura p1 = new Pintura("El salto del atún", 1, a1, 1998, 25.9, 14.5, "Lienzo"); 
		Pintura p2 = new Pintura("Ascensión", 2, a3, 1648, 225, 120, "Fresco"); 
		Escultura e1 = new Escultura("Cabeza azul", 3, a2, 2008, "Hormigón", 415);
		Escultura e2 = new Escultura("Poseidón y Ceto", 4, a3, 1621, "Mármol", 3);
		
		c.aniadeObra(p1);
		c.aniadeObra(p2);
		c.aniadeObra(e1);
		
		for (Obra o :c.getObras()) {
			o.muestra();
		}
		
		c.buscaObra(2);
		
		System.out.println(c.superficie());
		System.out.println(c.masAlta());
		
		c.eliminaObra(p1.getNumeroInv());
		
		for (Obra o :c.getObras()) {
			o.muestra();
		}
	}
}
