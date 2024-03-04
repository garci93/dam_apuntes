/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAOs;

import Errores.ErrorConsultaIncorrecta;
import POJOs.Jugador;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author dam
 */
public class DAOJugador {
    private DbConnection dbConnection;
    private Connection connection;

    public DAOJugador() {
        try {
            dbConnection = new DbConnection();
            connection = dbConnection.getConnection();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
    
    public List<Jugador> getJugadores() {
        List<Jugador> jugadores = new ArrayList<>();

        String sqlQuery = "SELECT * FROM jugadores";
        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                int dorsal = resultSet.getInt("dorsal");
                String nombre = resultSet.getString("nombre");
                double puntos = resultSet.getDouble("puntos");
                double rebotes = resultSet.getDouble("rebotes");
                double asistencias = resultSet.getDouble("asistencias");
                jugadores.add(new Jugador(dorsal, nombre, puntos, rebotes, asistencias));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return jugadores;
    }
    
    public List<Jugador> realizarConsulta(String consulta) throws SQLException, ErrorConsultaIncorrecta {
        List<Jugador> jugadores = new ArrayList<>();

        try (PreparedStatement statement = connection.prepareStatement(consulta)) {
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                int dorsal = resultSet.getInt("dorsal");
                String nombre = resultSet.getString("nombre");
                double puntos = resultSet.getDouble("puntos");
                double rebotes = resultSet.getDouble("rebotes");
                double asistencias = resultSet.getDouble("asistencias");
                jugadores.add(new Jugador(dorsal, nombre, puntos, rebotes, asistencias));
            }
        } catch (SQLException e) {
            throw new ErrorConsultaIncorrecta();
        }

        return jugadores;
    }
}
