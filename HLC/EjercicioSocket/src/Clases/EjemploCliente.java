package Clases;
import java.io.*;
import java.net.*;
public class EjemploCliente {
	public static void main(String[] args) throws Exception {
		//Nuestro host será el local
		String Host = "localhost";
		//Nuestro puero es el 6000
		int Puerto = 6000;
		System.out.println("Cliente iniciado.");
		//Crear nuevo socket cliente con el host y puerto dados
		Socket Cliente = new Socket(Host, Puerto);
		//Creamos el flujo de salida
		DataOutputStream flujoSalida = new DataOutputStream(Cliente.getOutputStream());
		//Enviamos un mensaje a través del flujo de salida con readutf
		flujoSalida.writeUTF("Saludos al servidor del cliente");
		//Creamos el flujo de entrada
		DataInputStream flujoEntrada = new DataInputStream(Cliente.getInputStream());
		//Recibimos un mensaje del servidor a través del flujo de entrada con writeutf y lo mostramos con sout
		System.out.println("Mensaje del servidor: \n\t" + flujoEntrada.readUTF());
		flujoEntrada.close();
		flujoSalida.close();
		Cliente.close();
	}
}