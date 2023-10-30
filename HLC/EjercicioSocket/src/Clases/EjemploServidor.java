package Clases;
import java.io.*;
import java.net.*;
public class EjemploServidor {
	public static void main(String[] args) throws IOException {
		int numeroPuerto = 90;
		ServerSocket servidor = new ServerSocket(numeroPuerto);
		System.out.println("Iniciando conexión...");
		while(true) {
            Socket cliente = servidor.accept();
            HiloServidor hilo = new HiloServidor(cliente);
            hilo.start();
        }
	}
}