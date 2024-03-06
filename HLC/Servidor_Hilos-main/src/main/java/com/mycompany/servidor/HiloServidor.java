/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.servidor;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.io.IOException;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.Socket;

/**
 *
 * @author cayet
 */
public class HiloServidor extends Thread{
    
    private Socket socket;
    private DataInputStream input;
    private DataOutputStream output;
    private Socket[] clientes;
    private Integer[] coordenadasPuntos;
    final int TAMANO_IMG = 300;
    final int MITAD_PANTALLA = (java.awt.Toolkit.getDefaultToolkit().getScreenSize().width/2)-(TAMANO_IMG/2);

    public HiloServidor(Socket cliente, Socket[] clientes, Integer[] coordenadasPuntos) throws IOException {
        this.socket = cliente;
        this.input = new DataInputStream(socket.getInputStream());
        this.output = new DataOutputStream(socket.getOutputStream());
        this.clientes = clientes;
        this.coordenadasPuntos = coordenadasPuntos;
    }
    
    public void run(){
        
        while (true) {
            try {
                String mensaje = input.readUTF();
                
                int cont = 0;
                
                int coordenadaMeta = 0;
                
                for (int i = clientes.length; i < coordenadasPuntos.length-1; i++) {
                    
                    cont += coordenadasPuntos[i];
                    
                }
                
                if(cont%2==0) coordenadaMeta = (((java.awt.Toolkit.getDefaultToolkit().getScreenSize().width)-TAMANO_IMG)-10);
                
                else coordenadaMeta = 10;
                
                for (int i = 0; i < clientes.length; i++) {
                    if(clientes[i]!=null) {
                        if (clientes[i].equals(socket)) {
                        coordenadasPuntos[i] = Integer.parseInt(mensaje);
                        
                        if(Integer.parseInt(mensaje)==coordenadaMeta) coordenadasPuntos[i+(clientes.length)]++;
                        
                        enviarMensajeATodos();
                        }
                    }
                    
                }
                
            } catch (IOException ex) {
                Logger.getLogger(HiloServidor.class.getName()).log(Level.SEVERE, null, ex);
                for (int i = 0; i < clientes.length; i++) {
                    if(clientes[i]!=null) {
                    
                        if (clientes[i].equals(socket)) {

                            clientes[i] = null;
                            coordenadasPuntos[i] = MITAD_PANTALLA;
                            coordenadasPuntos[i+(clientes.length)]=0;
                        }
                    }
                    
                }
                
                this.stop();
                
                }
        }
    }
    
    private void enviarMensajeATodos() throws IOException {
        
        StringBuilder coordenadasStrBuilder = new StringBuilder();
        for (Integer coordenada : coordenadasPuntos) {
            coordenadasStrBuilder.append(coordenada);
            coordenadasStrBuilder.append(",");
        }

        String coordenadasStr = coordenadasStrBuilder.toString();

        if (coordenadasStr.endsWith(",")) {
            coordenadasStr = coordenadasStr.substring(0, coordenadasStr.length() - 1);
        }
        for (Socket cliente : clientes) {
            if(cliente!=null) {
            output = new DataOutputStream(cliente.getOutputStream());
            output.writeUTF(coordenadasStr);
            }
        }
    }
    
}
