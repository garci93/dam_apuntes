package Servidor;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

/**
 * HiloServidor
 */
public class HiloServidor extends Thread {

    private Socket socket;

    public HiloServidor(Socket socket) {
        this.socket = socket;
    }

    public void run() {
        try {
            BufferedReader reader = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            PrintWriter writer = new PrintWriter(socket.getOutputStream(), true);
            String line;
            while ((line = reader.readLine()) != null) {
                System.out.println("Cadena recibida: " + line);
                writer.println("Número de caracteres: " + line.length());
            }
            socket.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}