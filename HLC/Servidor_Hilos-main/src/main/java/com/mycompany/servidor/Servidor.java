/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.servidor;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.concurrent.Executors;
import java.util.concurrent.ScheduledExecutorService;
import java.util.concurrent.TimeUnit;

/**
 *
 * @author cayet
 */
public class Servidor {

    public static void main(String[] args) throws IOException {
        
        final Integer MAX_CLIENTES = 4;
        final int MITAD_PANTALLA = (java.awt.Toolkit.getDefaultToolkit().getScreenSize().width/2)-150;
        final int TIEMPO = 90;
        final int PUERTO = 90;
        
        Socket[] clientes = {null, null, null, null};
        //4 primeras posiciones coordenadas, 4 siguientes puntos, ultima tiempo restante.
        Integer[] coordenadasPuntos = {MITAD_PANTALLA, MITAD_PANTALLA, MITAD_PANTALLA, MITAD_PANTALLA, 0, 0, 0, 0, 100};
        
        ScheduledExecutorService temporizador = Executors.newScheduledThreadPool(1);
        
        long tiempoEmpezado = System.currentTimeMillis();
        long duracion = TIEMPO * 1000;

        temporizador.scheduleWithFixedDelay(() -> {
            long tiempoActual = System.currentTimeMillis();
            long transcurrido = tiempoActual - tiempoEmpezado;
            long restante = Math.max(duracion - transcurrido, 0);
            
            coordenadasPuntos[coordenadasPuntos.length - 1] = (int) (restante / 1000);
            
            if(coordenadasPuntos[coordenadasPuntos.length - 1]==((TIEMPO/3)*2)-1) {
                
                for (int i = 0; i < coordenadasPuntos.length; i++) {
                    
                    if(i<clientes.length) coordenadasPuntos[i] = MITAD_PANTALLA;
                    
                    else if(i!=coordenadasPuntos.length-1) coordenadasPuntos[i] = 0;
                    
                }
                
            }
            
        }, 0, 1, TimeUnit.SECONDS);

        try (ServerSocket server = new ServerSocket(PUERTO);) {
            boolean finalizar = true;
            while (finalizar) {
                for (int i = 0; i < clientes.length; i++) {
                    if(clientes[i]==null) {
                        clientes[i] = server.accept();    
                        System.out.println("Cliente conectado");
                        coordenadasPuntos[i] = MITAD_PANTALLA ;
                        HiloServidor hs = new HiloServidor(clientes[i],clientes,coordenadasPuntos);
                        hs.start();
                    }
                }
                if(coordenadasPuntos[coordenadasPuntos.length-1]==0) finalizar=false; 
            }

        }
            
        catch(Exception e){
            System.out.println("Se ha liado.");
        }
        
    }
}
