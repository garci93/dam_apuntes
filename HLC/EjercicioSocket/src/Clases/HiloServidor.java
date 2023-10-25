package Clases;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class HiloServidor extends Thread {
    BufferedReader fentrada;
    PrintWriter fsalida;
    Socket socket = null;

    public HiloServidor(Socket s) {
        socket = s;
        //se crean flujos de entrada y salida
        try {
            fsalida = new PrintWriter(socket.getOutputStream(), true);
            fentrada = new BufferedReader(new InputStreamReader(
            socket.getInputStream()));
        } catch (IOException e){
            e.printStackTrace();
        }
    }

    public void run() {//tarea a realizar con el cliente
        String cadena="";
        try{
            while (!cadena.trim().equals("*")) {
            System.out.println("COMUNICO CON: "+ socket.toString());
            cadena = fentrada.readLine();//obtener cadena
            fsalida.println(cadena.trim().toUpperCase());//enviar mayúscula
        }// fin while
        System.out.println("FIN CON: "+ socket.toString());
        fsalida.close();
        fentrada.close();
        socket.close();
        } catch (IOException e){
            e.printStackTrace();
        }
    }
}