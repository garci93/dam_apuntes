package Clases;
import java.io.*;
import java.net.*;
public class EjemploCliente {
	public static void main(String[] args) throws Exception {
		String Host = "localhost";
		int Puerto = 6000;
		System.out.println("PROGRAMA CLIENTE INICIADO___");
		Socket Cliente = new Socket(Host, Puerto);
		DataOutputStream flujoSalida = new DataOutputStream(Cliente.getOutputStream());
		flujoSalida.writeUTF("Saludos al SERVIDOR DESDE EL CLIENTE");
		DataInputStream flujoEntrada = new DataInputStream(Cliente.getInputStream());
		System.out.println("Recibiendo del SERVIDOR: \n\t" + flujoEntrada.readUTF());
		flujoEntrada.close();
		flujoSalida.close();
		Cliente.close();
	}
}