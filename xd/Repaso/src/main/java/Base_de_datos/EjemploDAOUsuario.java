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
public class EjemploDAOUsuario {
    
    private static EjemploDAOUsuario dao=null; 
	private static Connection connection;
	
	
	private EjemploDAOUsuario() {
            connection = Connecion.enlace();
	}
	
        
	public int insertarUsuario(Usuario usuario) {
            String sqlQuery = "INSERT INTO usuarios (nombre, apellido) VALUES (?, ?)";
		
            try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
                statement.setString(1, usuario.getNombre());
                statement.setString(2, usuario.getApellido());

                if (statement.executeUpdate() > 0) {
                    return 1;
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }

            return 0;
	}
	
	public int eliminarUsuario(String nombre) {
            String sqlQuery = "DELETE FROM usuarios WHERE nombre = ?";

            try(PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
                statement.setString(1, nombre);

                if (statement.executeUpdate() > 0) {
                    System.out.println("Usuario eliminado exitosamente.");
                    return 1;
                }
            }
            catch(SQLException e) {
                e.printStackTrace();
            }
            return 0;
	}
	
	public List<Usuario> getUsuarios(){
            List<Usuario> listaUsuarios = new ArrayList<>();

            try {
                String sql = "SELECT idUsuario, nombre, apellido FROM usuarios";
                PreparedStatement statement = connection.prepareStatement(sql);
                ResultSet resultSet = statement.executeQuery();

                while (resultSet.next()) {
                    int id = resultSet.getInt("idUsuario");
                    String nombre = resultSet.getString("nombre");
                    String apellido = resultSet.getString("apellido");

                    Usuario usuario = new Usuario(nombre, apellido);
                    usuario.setId(id);
                    listaUsuarios.add(usuario);
                }

            } catch (SQLException e) {
                System.err.println(e.getMessage());
            }

            return listaUsuarios;
        
	}
	
        
        //Patron singleton
	public static EjemploDAOUsuario getInstance() {
            if(dao==null) {
                return dao = new EjemploDAOUsuario();
            }

            return dao;
	}

    
}
