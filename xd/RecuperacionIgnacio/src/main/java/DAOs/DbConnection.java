/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DAOs;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author dam
 */
public class DbConnection {
    static String bd = "db_jugadores";
    static String user = "root";
    static String password = "";
    static String url = "jdbc:mysql://localhost:3306/" + bd;
    private Connection connection = null;

    public DbConnection() throws SQLException {
        connection = DriverManager.getConnection(url, user, password);
    }

    public Connection getConnection() {
	return connection;
    }

    public void disconnect() throws SQLException {
	if (connection != null) {
            System.err.println("Closing database:[" + connection + "]...");
            connection.close();
            System.err.println("DB disconnect.");
	}
    }
}
