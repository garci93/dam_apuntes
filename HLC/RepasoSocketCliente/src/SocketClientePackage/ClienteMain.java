package SocketClientePackage;

import java.io.IOException;
import java.net.Socket;

public class ClienteMain {

	public static void main(String[] args) throws IOException {
		int puerto = 12345;
		
		Socket socket = new Socket("localhost",puerto);

	}

}
