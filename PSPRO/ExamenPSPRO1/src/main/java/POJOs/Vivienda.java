/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package POJOs;

/**
 *
 * @author dam
 */
public class Vivienda {
    
    private int codigo;

    private int piso;
    
    private String letra;

    private String propietario;
    
    private int tarifa;
    
    private boolean moroso;

    private int comunidad_id;

    public Vivienda() {
    }

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public int getPiso() {
        return piso;
    }

    public void setPiso(int piso) {
        this.piso = piso;
    }

    public String getLetra() {
        return letra;
    }

    public void setLetra(String letra) {
        this.letra = letra;
    }

    public String getPropietario() {
        return propietario;
    }

    public void setPropietario(String propietario) {
        this.propietario = propietario;
    }

    public int getTarifa() {
        return tarifa;
    }

    public void setTarifa(int tarifa) {
        this.tarifa = tarifa;
    }

    public boolean isMoroso() {
        return moroso;
    }

    public void setMoroso(boolean moroso) {
        this.moroso = moroso;
    }

    public int getComunidad_id() {
        return comunidad_id;
    }

    public void setComunidad_id(int comunidad_id) {
        this.comunidad_id = comunidad_id;
    }

    @Override
    public String toString() {
        return "Vivienda{" + "codigo=" + codigo + ", piso=" + piso + ", letra=" + letra + ", propietario=" + propietario + ", tarifa=" + tarifa + ", moroso=" + moroso + ", comunidad_id=" + comunidad_id + '}';
    }
    
    
}
