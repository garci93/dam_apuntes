import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;

class Servidor {
    public static void main (){
        int puerto = 4000;
        int conexion = 0;
        int maxHilos = 2;
        ArrayList<Socket> arraySockets = null;
        while (conexion < maxHilos){
                conexion++;
                HilosServidor hilo = new HilosServidor(new Socket(), arraySockets);
                hilo.start();
            }
    }
}