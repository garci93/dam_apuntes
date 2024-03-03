package DAOs;

import POJOs.Comunidad;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import javax.swing.table.DefaultTableModel;

public class DAOComunidadImpl {
	BD1 bd1 = new BD1();
        Connection conexion = BD1.enlace();

	public DAOComunidadImpl() {}

	public ResultSet getComunidades() {
		Statement statement;
                ResultSet resultSet = null;
                try {
                    statement = conexion.createStatement();
                    resultSet = statement.executeQuery("SELECT * FROM comunidad");
                } catch (SQLException ex) {
                    System.out.println("Error en la consulta SQL: " + ex.getMessage());
                    ex.printStackTrace();
                }
                return resultSet;
	}

}
