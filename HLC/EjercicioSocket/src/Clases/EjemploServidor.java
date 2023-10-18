package Clases;
import java.io.*;
import java.net.*;
public class EjemploServidor {
	public static void main(String[] args) throws IOException {
		int numeroPuerto = 6000;
		ServerSocket servidor = new ServerSocket(numeroPuerto);
		Socket clienteConectado = null;
		System.out.println("Servidor iniciado. Esperando al cliente...");
		clienteConectado = servidor.accept();
		
		InputStream entrada = null;
		entrada = clienteConectado.getInputStream();
		DataInputStream flujoEntrada = new DataInputStream(entrada);
		System.out.println("Mensaje del cliente: \n\t" + flujoEntrada.readUTF());
		OutputStream salida = null;
		salida = clienteConectado.getOutputStream();
		DataOutputStream flujoSalida = new DataOutputStream(salida);
		flujoSalida.writeUTF("Saludos al cliente del servidor");
		entrada.close();
		flujoEntrada.close();
		salida.close ();
		flujoSalida.close ();
		clienteConectado.close();
		servidor.close();
	}
}