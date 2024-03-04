/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.mycompany.recuperacionignacio;

import POJOs.Jugador;
import java.util.ArrayList;
import java.util.List;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import org.mockito.ArgumentMatchers;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.Mockito;

/**
 *
 * @author dam
 */
public class PantallaJugadoresTest {
    @InjectMocks
    private static PantallaJugadores pantallaJugadores;
    
    @Mock
    private static DAOs.DAOJugador daoJugador;
    
    public PantallaJugadoresTest() {
    }
    
    @Test
    public void testObtenerJugadores() {
        daoJugador = Mockito.mock(DAOs.DAOJugador.class);
        
        pantallaJugadores = new PantallaJugadores(daoJugador);
        
        Jugador jugador1 = new Jugador(23, "Sergio Llull", 12.4, 2.4, 4.2);
        Jugador jugador2 = new Jugador(27, "Facundo Campazzo", 11.4, 1.3, 1.5);
        Jugador jugador3 = new Jugador(12, "Edy Tavares", 9.1, 8, 0.4);
        Jugador jugador4 = new Jugador(22, "Mario Herzonja", 10.5, 6, 2);
        Jugador jugador5 = new Jugador(11, "Carlos Alocén", 5.2, 2.5, 4.2);
        
        List<Jugador> jugadores = new ArrayList<>();
        jugadores.add(jugador1);
        jugadores.add(jugador2);
        jugadores.add(jugador3);
        jugadores.add(jugador4);
        jugadores.add(jugador5);
        
        List<Jugador> expResult = new ArrayList<>();
        expResult.add(jugador1);
        expResult.add(jugador2);
        expResult.add(jugador4);
        
        Mockito.when(daoJugador.getJugadores()).thenReturn(jugadores);
        
        List<Jugador> result = pantallaJugadores.contarAnotadores(10);
        assertEquals(expResult, result);
    }
    
}
