/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Base_de_datos;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author santi
 */
public class EjemploDAOVehiculo {
    
    private static EjemploDAOVehiculo dao=null; 
    private static Connection connection;

    private EjemploDAOVehiculo() {
        super();
        connection = Connecion.enlace();
    }


    public int insertarVehiculo(Vehiculo vehiculo) {
        String sqlQuery = "INSERT INTO vehiculos (marca, modelo, matricula, idUsuario) VALUES (?, ?, ?, ?)";

        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            statement.setString(1, vehiculo.getMarca());
            statement.setString(2, vehiculo.getModelo());
            statement.setString(3, vehiculo.getMatricula());
            statement.setInt(4, vehiculo.getIdUsuario());

            if (statement.executeUpdate() > 0) {
                return 1;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return 0;
    }


    public int eliminarVehiculo(int idUsuario) {
        String sqlQuery = "DELETE FROM vehiculos WHERE idUsuario = ?";

        try(PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
                statement.setInt(1, idUsuario);

        if (statement.executeUpdate() > 0) {
            System.out.println("Vehiculos eliminado exitosamente.");
            return 1;
        }
        }
        catch(SQLException e) {
                e.printStackTrace();
        }
        return 0;
    }




    public List<Vehiculo> getVehiculos(){
        List<Vehiculo> listaVehiculos = new ArrayList<>();

        try {
            String sql = "SELECT marca, modelo, matricula, idUsuario FROM vehiculos";
            PreparedStatement statement = connection.prepareStatement(sql);
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
                String marca = resultSet.getString("marca");
                String modelo = resultSet.getString("modelo");
                String matricula = resultSet.getString("matricula");
                int idUsuario = resultSet.getInt("idUsuario");

                Vehiculo vehiculo = new Vehiculo(marca, modelo, matricula, idUsuario);

                listaVehiculos.add(vehiculo);
            }

        } catch (SQLException e) {
            System.err.println(e.getMessage());
        }

        return listaVehiculos;
    }


    //Patron Singleton
    public static EjemploDAOVehiculo getInstance() {
        if (dao== null){
            return dao =new EjemploDAOVehiculo();
        }
        return dao;
    }

}
