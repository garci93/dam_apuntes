package Clases;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class HiloServidor extends Thread {
	BufferedReader entrada;
	PrintWriter salida;
	Socket cliente = null;

	public HiloServidor(Socket socket) {
		this.cliente = socket;
	}

	public void run() {

		try {
			entrada = new BufferedReader(new InputStreamReader(cliente.getInputStream()));
			salida = new PrintWriter(cliente.getOutputStream(), true);

//            String cadena = entrada.readLine();

//            System.out.println("Cadena: " + cadena.toString());

//            if (cadena != null && cadena.startsWith("GET ")) {
//                String[] requestParts = cadena.split(" ");
//                
//                String direccionArchivo = requestParts[1].substring(1);
//                // quitamos el / del principio
//
//                File archivo = new File(direccionArchivo);
//                // esto es src/index.html
//                
//                if (archivo.exists() && archivo.isFile()) {
//                    salida.println("HTTP/1.1 200 OK");
//                    salida.println("Content-Type: text/html");
//                    salida.println();
//
//                    BufferedReader bufferedReader = new BufferedReader(new FileReader(archivo));
//                    
//                    String linea;
//                    while ((linea = bufferedReader.readLine()) != null) {
//                        salida.println(linea);
//                    }
//                    bufferedReader.close();
//                } 
//                else {
//                    salida.println("HTTP/1.1 404 Not Found");
//                    salida.println("Content-Type: text/html");
//                    salida.println();
//                    salida.println("404 - File Not Found");
//                }
//            }    
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}