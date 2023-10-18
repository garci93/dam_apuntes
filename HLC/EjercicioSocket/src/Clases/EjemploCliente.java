package Clases;
import java.io.*;
import java.net.*;
public class EjemploCliente {
	public static void main(String[] args) throws Exception {
		String Host = "localhost";
		int Puerto = 6000;
		System.out.println("Cliente iniciado.");
		Socket Cliente = new Socket(Host, Puerto);
		DataOutputStream flujoSalida = new DataOutputStream(Cliente.getOutputStream());
		flujoSalida.writeUTF("Saludos al servidor del cliente");
		DataInputStream flujoEntrada = new DataInputStream(Cliente.getInputStream());
		System.out.println("Mensaje del servidor: \n\t" + flujoEntrada.readUTF());
		flujoEntrada.close();
		flujoSalida.close();
		Cliente.close();
	}
}