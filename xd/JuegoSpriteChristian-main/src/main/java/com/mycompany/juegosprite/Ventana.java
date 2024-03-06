/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package com.mycompany.juegosprite;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFrame;

/**
 *
 * @author cayet
 */
public class Ventana extends javax.swing.JFrame{
    
    private final String IP = "127.0.0.1";
    private final int PUERTO = 90;
    private final int VELOCIDAD = 40;
    public final int TIEMPO = 90;
    public final int TIEMPO_RESTANTE = 60;
    final int MITAD_PANTALLA = (java.awt.Toolkit.getDefaultToolkit().getScreenSize().width/2)-150;
    public Integer ancho_pantalla;
    public Socket socket;
    public DataInputStream input;
    public DataOutputStream output;
    public int coordenada;
    
    
    public Ventana() throws IOException {
        initComponents();
        setVisible(true);
        setResizable(false);
        this.socket = new Socket(IP,PUERTO);
        setExtendedState(JFrame.MAXIMIZED_BOTH);
        this.input = new DataInputStream(socket.getInputStream());
        this.output = new DataOutputStream(socket.getOutputStream());
        this.coordenada = MITAD_PANTALLA;
    }
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        panel = new javax.swing.JPanel();
        lblCoche1 = new javax.swing.JLabel();
        lblCoche1Puntos = new javax.swing.JLabel();
        lblCoche2Puntos = new javax.swing.JLabel();
        lblCoche3Puntos = new javax.swing.JLabel();
        lblCoche4Puntos = new javax.swing.JLabel();
        lblTiempo = new javax.swing.JLabel();
        lblCoche2 = new javax.swing.JLabel();
        lblCoche3 = new javax.swing.JLabel();
        lblCoche4 = new javax.swing.JLabel();
        lblBanderaFinal = new javax.swing.JLabel();
        lblFondoPantalla = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Carrera Coches");
        setSize(new java.awt.Dimension(1920, 1080));
        addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                formKeyReleased(evt);
            }
        });

        panel.setLayout(null);

        lblCoche1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblCoche1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche1Derecha.png"))); // NOI18N
        panel.add(lblCoche1);
        lblCoche1.setBounds(810, 10, 300, 205);

        lblCoche1Puntos.setFont(new java.awt.Font("Segoe UI", 1, 48)); // NOI18N
        lblCoche1Puntos.setForeground(new java.awt.Color(255, 255, 255));
        lblCoche1Puntos.setText("Coche 1:");
        panel.add(lblCoche1Puntos);
        lblCoche1Puntos.setBounds(220, 490, 540, 60);

        lblCoche2Puntos.setFont(new java.awt.Font("Segoe UI", 1, 48)); // NOI18N
        lblCoche2Puntos.setForeground(new java.awt.Color(255, 255, 255));
        lblCoche2Puntos.setText("Coche 2: ");
        panel.add(lblCoche2Puntos);
        lblCoche2Puntos.setBounds(220, 780, 540, 60);

        lblCoche3Puntos.setFont(new java.awt.Font("Segoe UI", 1, 48)); // NOI18N
        lblCoche3Puntos.setForeground(new java.awt.Color(255, 255, 255));
        lblCoche3Puntos.setText("Coche 3:");
        panel.add(lblCoche3Puntos);
        lblCoche3Puntos.setBounds(1280, 490, 540, 60);

        lblCoche4Puntos.setFont(new java.awt.Font("Segoe UI", 1, 48)); // NOI18N
        lblCoche4Puntos.setForeground(new java.awt.Color(255, 255, 255));
        lblCoche4Puntos.setText("Coche 4:");
        panel.add(lblCoche4Puntos);
        lblCoche4Puntos.setBounds(1280, 780, 540, 60);

        lblTiempo.setFont(new java.awt.Font("Segoe UI", 1, 48)); // NOI18N
        lblTiempo.setForeground(new java.awt.Color(0, 0, 0));
        lblTiempo.setText("Tiempo Preparacion:");
        panel.add(lblTiempo);
        lblTiempo.setBounds(750, 240, 540, 60);

        lblCoche2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblCoche2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche2Derecha.png"))); // NOI18N
        panel.add(lblCoche2);
        lblCoche2.setBounds(810, 320, 300, 171);

        lblCoche3.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblCoche3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche3Derecha.png"))); // NOI18N
        panel.add(lblCoche3);
        lblCoche3.setBounds(810, 560, 300, 199);

        lblCoche4.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblCoche4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche4Derecha.png"))); // NOI18N
        panel.add(lblCoche4);
        lblCoche4.setBounds(810, 860, 300, 195);

        lblBanderaFinal.setIcon(new javax.swing.ImageIcon(getClass().getResource("/banderaMeta.png"))); // NOI18N
        panel.add(lblBanderaFinal);
        lblBanderaFinal.setBounds(1820, 0, 104, 1060);

        lblFondoPantalla.setIcon(new javax.swing.ImageIcon(getClass().getResource("/carretera.jpg"))); // NOI18N
        lblFondoPantalla.setPreferredSize(new java.awt.Dimension(2100, 1080));
        panel.add(lblFondoPantalla);
        lblFondoPantalla.setBounds(0, 0, 2100, 1180);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(panel, javax.swing.GroupLayout.PREFERRED_SIZE, 1920, javax.swing.GroupLayout.PREFERRED_SIZE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(panel, javax.swing.GroupLayout.PREFERRED_SIZE, 1080, javax.swing.GroupLayout.PREFERRED_SIZE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_formKeyReleased
        // TODO add your handling code here:
        
        if (evt.getKeyCode() == 37 && coordenada-VELOCIDAD >=0) {
            coordenada -= VELOCIDAD;
        }
        else if (evt.getKeyCode() == 39 && coordenada+VELOCIDAD <= MITAD_PANTALLA*2){
            coordenada += VELOCIDAD;
        }
        try {
            output.writeUTF(Integer.toString(coordenada));
        } catch (IOException ex) {
            Logger.getLogger(Ventana.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_formKeyReleased

    public void modificarLayout(String[] coordenadasPuntosInput, Integer[] coordenadas) {
        
        int cont = 0;
                                
        for (int i = 0; i < coordenadasPuntosInput.length-1; i++) {

            switch (i) {
                case 0:
                    if(Integer.parseInt(coordenadasPuntosInput[i])>coordenadas[i]) lblCoche1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche1Derecha.png")));
                    if(Integer.parseInt(coordenadasPuntosInput[i])<coordenadas[i]) lblCoche1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche1Izquierda.png")));
                    lblCoche1.setLocation(Integer.parseInt(coordenadasPuntosInput[i]), (int) lblCoche1.getLocation().getY());
                    coordenadas[i] = Integer.parseInt(coordenadasPuntosInput[i]);
                    break;
                case 1:
                    if(Integer.parseInt(coordenadasPuntosInput[i])>coordenadas[i]) lblCoche2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche2Derecha.png")));
                    if(Integer.parseInt(coordenadasPuntosInput[i])<coordenadas[i]) lblCoche2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche2Izquierda.png")));
                    lblCoche2.setLocation(Integer.parseInt(coordenadasPuntosInput[i]), (int) lblCoche2.getLocation().getY());
                    coordenadas[i] = Integer.parseInt(coordenadasPuntosInput[i]);
                    break;
                case 2:
                    if(Integer.parseInt(coordenadasPuntosInput[i])>coordenadas[i]) lblCoche3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche3Derecha.png")));
                    if(Integer.parseInt(coordenadasPuntosInput[i])<coordenadas[i]) lblCoche3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche3Izquierda.png")));
                    lblCoche3.setLocation(Integer.parseInt(coordenadasPuntosInput[i]), (int) lblCoche3.getLocation().getY());
                    coordenadas[i] = Integer.parseInt(coordenadasPuntosInput[i]);
                    break;
                case 3:
                    if(Integer.parseInt(coordenadasPuntosInput[i])>coordenadas[i]) lblCoche4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche4Derecha.png")));
                    if(Integer.parseInt(coordenadasPuntosInput[i])<coordenadas[i]) lblCoche4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche4Izquierda.png")));
                    lblCoche4.setLocation(Integer.parseInt(coordenadasPuntosInput[i]), (int) lblCoche4.getLocation().getY());
                    coordenadas[i] = Integer.parseInt(coordenadasPuntosInput[i]);
                    break;
                default:
                    cont+=Integer.parseInt(coordenadasPuntosInput[i]);
            }

        }

        if(cont%2==0) lblBanderaFinal.setLocation((java.awt.Toolkit.getDefaultToolkit().getScreenSize().width)-100, (int) lblBanderaFinal.getLocation().getY());

        else lblBanderaFinal.setLocation(0, (int) lblBanderaFinal.getLocation().getY());

        for (int i = coordenadas.length; i < coordenadasPuntosInput.length-1; i++) {

            switch (i) {
                case 4:
                    lblCoche1Puntos.setText("Coche 1 = " + coordenadasPuntosInput[i]);
                    break;
                case 5:
                    lblCoche2Puntos.setText("Coche 2 = " + coordenadasPuntosInput[i]);
                    break;
                case 6:
                    lblCoche3Puntos.setText("Coche 3 = " + coordenadasPuntosInput[i]);
                    break;
                case 7:
                    lblCoche4Puntos.setText("Coche 4 = " + coordenadasPuntosInput[i]);
                    break;
                default:
                    break;
            }

        }
        
    }
    
    public void modificarTiempo(String[] coordenadasPuntosInput) {
        
        if(Integer.parseInt(coordenadasPuntosInput[coordenadasPuntosInput.length-1])>TIEMPO_RESTANTE) lblTiempo.setText("Tiempo Preparacion: " + (Integer.parseInt(coordenadasPuntosInput[coordenadasPuntosInput.length-1])-TIEMPO_RESTANTE));
                                
        else if(Integer.parseInt(coordenadasPuntosInput[coordenadasPuntosInput.length-1])==TIEMPO_RESTANTE) {
            coordenada = MITAD_PANTALLA;
            lblCoche1.setLocation(coordenada, (int) lblCoche1.getLocation().getY());
            lblCoche1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche1Derecha.png")));
            lblCoche2.setLocation(coordenada, (int) lblCoche2.getLocation().getY());
            lblCoche2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche2Derecha.png")));
            lblCoche3.setLocation(coordenada, (int) lblCoche3.getLocation().getY());
            lblCoche3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche3Derecha.png")));
            lblCoche4.setLocation(coordenada, (int) lblCoche4.getLocation().getY());
            lblCoche4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/coche4Derecha.png")));
        }

        else lblTiempo.setText("Tiempo Restante: " + coordenadasPuntosInput[coordenadasPuntosInput.length-1]);
        
    }


    // Variables declaration - do not modify//GEN-BEGIN:variables
    public javax.swing.JLabel lblBanderaFinal;
    public javax.swing.JLabel lblCoche1;
    public javax.swing.JLabel lblCoche1Puntos;
    public javax.swing.JLabel lblCoche2;
    public javax.swing.JLabel lblCoche2Puntos;
    public javax.swing.JLabel lblCoche3;
    public javax.swing.JLabel lblCoche3Puntos;
    public javax.swing.JLabel lblCoche4;
    public javax.swing.JLabel lblCoche4Puntos;
    private javax.swing.JLabel lblFondoPantalla;
    public javax.swing.JLabel lblTiempo;
    private javax.swing.JPanel panel;
    // End of variables declaration//GEN-END:variables
}
