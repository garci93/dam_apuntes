package SocketPackage;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.ArrayList;

public class HilosServidor extends Thread {
	Socket socket = null;
	ArrayList<Socket> arraySocket = null;
	DataInputStream fentrada;
	DataOutputStream fsalida;
	
	HilosServidor (Socket socket, ArrayList<Socket> arraySocket){
		this.socket = socket;
		this.arraySocket = arraySocket;
	}
	
	public void run() {
		try {
			fentrada = new DataInputStream(socket.getInputStream());
			fsalida = new DataOutputStream(socket.getOutputStream());
		}catch (IOException e){
			e.printStackTrace();
		}
	}
}
