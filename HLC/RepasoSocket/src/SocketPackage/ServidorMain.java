package SocketPackage;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;

public class ServidorMain {

	public static void main(String[] args) throws IOException {
		int puerto = 12345;
		
		int conexion = 0;
		
		final int maxHilos = 5;
		
		ServerSocket socketServidor = new ServerSocket(puerto);
		
		ArrayList<Socket> arraySocket = new ArrayList<Socket>();
		
		while(conexion < maxHilos) {
			conexion++;
			Socket socket = new Socket();
			socket = socketServidor.accept();
			HilosServidor hilo = new HilosServidor(socket, arraySocket);
			hilo.start();
		}
	}

}
