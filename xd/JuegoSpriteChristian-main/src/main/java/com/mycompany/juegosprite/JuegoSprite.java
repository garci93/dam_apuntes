/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.juegosprite;

import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author cayet
 */
public class JuegoSprite {

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Ventana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Ventana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Ventana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Ventana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                try {
                    Ventana ventana = new Ventana();
                    Integer[] coordenadas = {ventana.MITAD_PANTALLA, ventana.MITAD_PANTALLA, ventana.MITAD_PANTALLA, ventana.MITAD_PANTALLA};
                    Thread clientThread = new Thread(() -> {
                        try {

                            boolean finalizar = true;
                            
                            while (finalizar) {
                                
                                String coordenadasStr = ventana.input.readUTF();
                                
                                String[] coordenadasPuntosInput = coordenadasStr.split(",");
                                
                                ventana.modificarTiempo(coordenadasPuntosInput);
                                
                                ventana.modificarLayout(coordenadasPuntosInput, coordenadas);
                                
                                //System.out.println("Coordenadas recibidas: " + coordenadasStr);
                                
                                if(Integer.parseInt(coordenadasPuntosInput[coordenadasPuntosInput.length-1])==0) {
                                    finalizar=false;
                                    ventana.lblCoche1Puntos.setForeground(new java.awt.Color(0, 0, 0));
                                    ventana.lblCoche2Puntos.setForeground(new java.awt.Color(0, 0, 0));
                                    ventana.lblCoche3Puntos.setForeground(new java.awt.Color(0, 0, 0));
                                    ventana.lblCoche4Puntos.setForeground(new java.awt.Color(0, 0, 0));
                                }
                                
                            }
                        } catch (IOException e) {
                            e.printStackTrace();
                        }
                    });

                    // Inicia el hilo del cliente
                    clientThread.start();
                } catch (IOException ex) {
                    Logger.getLogger(JuegoSprite.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        });
    }
    
    
    
    
}
