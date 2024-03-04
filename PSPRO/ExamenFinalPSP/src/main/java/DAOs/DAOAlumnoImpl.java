/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAOs;

import POJOs.Alumno;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author dam
 */
public class DAOAlumnoImpl implements IDAOAlumno {

    
    BD1 bd1 = new BD1();
    Connection conexion = BD1.enlace();
    List<Alumno> alumnos = new ArrayList<>();

    public DAOAlumnoImpl() {}

    public List<Alumno> getAlumnos() {
        String sqlQuery = "SELECT * FROM alumnos";
        try (PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                String dni = resultSet.getString("dni");
                String nombre = resultSet.getString("nombre");
                alumnos.add(new Alumno(dni, nombre));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return alumnos;
    }
}
