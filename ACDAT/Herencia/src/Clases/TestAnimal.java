package Clases;

public class TestAnimal {
	public static void main (String[] args) {
//		Animal a = new Animal("Kuki","Perro");
//		Animal b = new Animal();
		Animal zoo[] = {new Mamifero ("Peggi","Cerdo",8),
			new Mamifero ("Copito","Perro",8),
			new Reptil ("Arcoiris","Camaleon",20)};
		
		for(Animal animal:zoo) {
			System.out.println(animal);
			if (animal instanceof Reptil) {
				Reptil reptil = (Reptil) animal;
				System.out.println(reptil.temperaturaMortal());
			}
		}
		
	}
}
