import java.io.IOException;
import java.net.Socket;
import java.util.ArrayList;

class HilosServidor extends Thread {

    Socket socket = null;
    Socket arraySockets = null;
    
    HilosServidor (Socket socket, ArrayList<Socket> arraySockets){
        this.socket = socket;
        this.arraySockets = arraySockets;
    }

    public void run(){
        try {
            
        }catch (IOException e){
            e.printStackTrace();
        }
    }
}