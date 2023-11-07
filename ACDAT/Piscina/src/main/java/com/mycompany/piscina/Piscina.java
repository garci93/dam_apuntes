/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.piscina;

import javax.swing.JOptionPane;

/**
 *
 * @author dam
 */
public class Piscina {

    private int nivel;
    public final int MAX_NIVEL;
    
    public Piscina (int max){
        if (max < 0) max = 0;
        MAX_NIVEL = max;
    }

    public int getNivel() {
        return nivel;
    }
    
    public void vaciar (int cantidad){
        try {
            nivel = nivel - cantidad;
            if(nivel < 0){
                throw new Exception();
            }
        } catch (Exception e){
            JOptionPane.showMessageDialog(null, 
                    "No queda agua suficiente.");
        }
    }
    
    public void llenar (int cantidad) throws Exception {
        try {
            nivel = nivel + cantidad;
            if(nivel > MAX_NIVEL){
                throw new Exception();
            }
        } catch (Exception e){
            JOptionPane.showMessageDialog(null, 
                    "Se desborda con tanta agua.");
        }
    }
}
