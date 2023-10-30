package Ejercicio1;

public class Excepcion1{
	public static void main(String args[])
	{
		int numero[]=new int[5];
		try {
			numero[7]=0;
		} catch (IndexOutOfBoundsException e) {
			System.out.println(e.toString());
		}
	}
}
