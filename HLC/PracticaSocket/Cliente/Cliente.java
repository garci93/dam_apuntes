package Cliente;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class Cliente {
    public static void main(String[] args) {
        Socket socket = new Socket("localhost", 2000);
        BufferedReader reader = new BufferedReader(new InputStreamReader(socket.getInputStream()));

        PrintWriter writer = new PrintWriter(socket.getOutputStream(), true);
        writer.println("Hola, servidor");
        System.out.println("Mensaje del servidor: " + reader.readLine());
    }
}
