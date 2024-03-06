package Servidor;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

/**
 * Servidor
 */
public class Servidor {
    final int PORT = 2000;
    final String HOST = "localhost";
    //No hay un MAX_THREADS, ya que puede haber un número indefinido de clientes

    public Servidor() {
        try {
            ServerSocket server = new ServerSocket(PORT);
            System.out.println("Servidor iniciado en el puerto " + PORT);
            while (true) {
                Socket socket = server.accept();
                System.out.println("Cliente conectado desde " + socket.getInetAddress() + ":" + socket.getPort());
                new HiloServidor(socket).start();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}