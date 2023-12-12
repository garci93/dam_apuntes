/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ClasesMetodosGenericos;

/**
 *
 * @author santi
 */
public class ClaseGenerica<T> {
    
    private T dato;

    public ClaseGenerica() {

    }

    public T quita() {
            return dato;
    }

    public void pon(T dato) {
            this.dato = dato;
    }

    //METODO GENERICO
    public <M> void imprimirDato(M dato){
            System.out.println(dato);
    }
    
    
    //LO COMENTADO ABAJO IRIA EN UN MAIN
    /*
    ClaseGenerica<Integer> clase1 = new ClaseGenerica(); //clase generica con integer

    clase1.pon(5);
    Integer dato1 = clase1.quita();
    clase1.imprimirDato("Hola");

    ClaseGenerica<String> clase2 = new ClaseGenerica(); //clase generica con string

    clase2.pon("AB");
    String dato2 = clase2.quita();
    clase2.imprimirDato(50);

    */
}
