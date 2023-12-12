/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package JUnit;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import static org.mockito.Mockito.mock;
import static org.mockito.Mockito.times;
import static org.mockito.Mockito.verify;
import static org.mockito.Mockito.when;

/**
 *
 * @author santi
 */
public class OperacionesMatematicasTest {
    
    public OperacionesMatematicasTest() {
    }
    
    @BeforeAll
    public static void setUpClass() {
    }
    
    @AfterAll
    public static void tearDownClass() {
    }
    
    @BeforeEach
    public void setUp() {
    }
    
    @AfterEach
    public void tearDown() {
    }

    
    //PRUEBAS UNITARIAS SIN MOCK Y SIN MOCKITO
    /*
    @Test
    public void testSumar() {
        System.out.println("sumar");
        int a = 5;
        int b = 3;
        OperacionesMatematicas instance = new OperacionesMatematicas();
        int expResult = 8;
        int result = instance.sumar(a, b);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        //fail("The test case is a prototype.");
    }


    @Test
    public void testRestar() {
        System.out.println("restar");
        int a = 0;
        int b = 0;
        OperacionesMatematicas instance = new OperacionesMatematicas();
        int expResult = 0;
        int result = instance.restar(a, b);
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        //fail("The test case is a prototype.");
    }
    */
    
    
    //CON MOCKITO
    /*
    @Test
    public void testSumar() {
        // Crear un mock para la clase OperacionesMatematicas
        OperacionesMatematicas operacionesMock = mock(OperacionesMatematicas.class);

        // Configurar el comportamiento esperado del mock
        when(operacionesMock.sumar(3, 4)).thenReturn(7);

        // Verificar que el método sumar se llama con los argumentos esperados
        int resultado = operacionesMock.sumar(3, 4);
        assertEquals(7, resultado);

        // Verificar que el método sumar se llamó exactamente una vez con los argumentos esperados
        verify(operacionesMock, times(1)).sumar(3, 4);
    }

    @Test
    public void testRestar() {
        // Crear un mock para la clase OperacionesMatematicas
        OperacionesMatematicas operacionesMock = mock(OperacionesMatematicas.class);

        // Configurar el comportamiento esperado del mock
        when(operacionesMock.restar(8, 5)).thenReturn(3);

        // Verificar que el método restar se llama con los argumentos esperados
        int resultado = operacionesMock.restar(8, 5);
        assertEquals(3, resultado);

        // Verificar que el método restar se llamó exactamente una vez con los argumentos esperados
        verify(operacionesMock, times(1)).restar(8, 5);
    }
    */
    
    
    //CON MOCK
      
    @Test
    public void testMultiplicarExterno() {
        // Crear un mock para la interfaz CalculadoraExterna
        CalculadoraExterna calculadoraExternaMock = mock(CalculadoraExterna.class);

        // Configurar el comportamiento esperado del mock
        when(calculadoraExternaMock.multiplicar(3, 4)).thenReturn(12);

        // Crear una instancia de OperacionesMatematicas con el mock
        OperacionesMatematicas operaciones = new OperacionesMatematicas(calculadoraExternaMock);

        // Llamar al método que utiliza la CalculadoraExterna en la clase OperacionesMatematicas
        int resultado = operaciones.multiplicar(3, 4);

        // Verificar que el resultado es el esperado
        assertEquals(12, resultado);

        // Verificar que el método multiplicar de CalculadoraExterna se llamó exactamente una vez con los argumentos esperados
        verify(calculadoraExternaMock, times(1)).multiplicar(3, 4);
    }
    
    
    
}
