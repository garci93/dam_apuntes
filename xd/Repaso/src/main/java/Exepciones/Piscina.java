/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Exepciones;

import java.io.IOException;

/**
 *
 * @author santi
 */
public class Piscina {
    
    private int nivel;
    public final double MAX_NIVEL;
    
    public Piscina(double max){
        if(max<0) max=0;
        MAX_NIVEL = max;
    }
    
    public int getNivel(){
        return nivel;
    }
    
    public void vaciar(int cantidad) throws IOException{
        
        if(nivel-cantidad<0){
             throw new IOException("El nivel no puede quedar por debajo de cero.");
        }
        else{
            nivel=nivel-cantidad;
        }
        
    }
    
    public void llenar(int cantidad) throws IOException{

        if (nivel + cantidad > MAX_NIVEL) {
            throw new IOException("El nivel no puede quedar por encima del máximo.");
        } else {
            nivel = nivel + cantidad;
        }
    }
    
}

//ESTO SE HA SACADO DE UN EJERCICIO EN SWING DONDE SE PRUEBAN LOS METODOS CON EXEPCIONES

//EL SIGUIENTE BLOQUE DE CODIGO SE HA SACADO DE UN BOTON 'LLENAR'

/*
    int litros = random.nextInt(1000) + 1; 

    try {
        piscina.llenar(litros);
        jTextArea1.setText(jTextArea1.getText()+"\nLlenado..." + litros + " nivel="+piscina.getNivel()+"\n-----------------------------------------\n");
        slider.setValue(piscina.getNivel());
    } catch (IOException ex) {
        jTextArea1.setText(jTextArea1.getText()+"\nError: " + ex.getMessage()+"\n");
    }
*/


//EL SIGUIENTE BLOQUE DE CODIGO SE HA SACADO DE UN BOTON 'VACIAR'
/*
    int litros = random.nextInt(1000) + 1; 

    try {
        piscina.vaciar(litros);
        jTextArea1.setText(jTextArea1.getText()+"\nVaciado..." + litros + " nivel="+piscina.getNivel()+"\n-----------------------------------------\n");
        slider.setValue(piscina.getNivel());
    } catch (IOException ex) {
        jTextArea1.setText(jTextArea1.getText()+"\nError: " + ex.getMessage()+"\n");
    }
*/