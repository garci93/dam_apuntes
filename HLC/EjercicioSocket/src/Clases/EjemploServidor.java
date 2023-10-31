package Clases;
import java.io.*;
import java.net.*;
public class EjemploServidor {
	private static int numJugadores = 0;
	private static int maxJugadores = 8;
	public static void main(String[] args) throws IOException {
		int numeroPuerto = 90;
		ServerSocket servidor = new ServerSocket(numeroPuerto);
		System.out.println("Iniciando conexión...");
		while(true) {
			if (numJugadores < maxJugadores) {
				Socket cliente = servidor.accept();
	            HiloServidor hilo = new HiloServidor(cliente);
	            hilo.start();
	            numJugadores++;
			}
        }
	}
	
	public int getNumJugadores() {
		return this.numJugadores;
	}
}