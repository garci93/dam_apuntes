package Clases;
import java.io.*;
import java.net.*;
public class EjemploServidor {
	public static void main(String[] args) throws IOException {
		int numeroPuerto = 90;
		ServerSocket servidor = new ServerSocket(numeroPuerto);
		// Socket clienteConectado = null;
		while (true) {
			Socket cliente = new Socket();
			cliente=servidor.accept(); //esperando cliente
			HiloServidor hilo = new HiloServidor(cliente);
			hilo.start(); //se atiende al cliente
			}
	}
}