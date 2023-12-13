package DAOs;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import javax.swing.table.DefaultTableModel;

import Recursos.Cliente;
import Recursos.Vehiculo;

public class DAOVehiculoImpl implements IDAOVehiculo {

	private List<Vehiculo> falsaBD;
	private static IDAOVehiculo dao = null;
	private BD1 dbConnection;
	private Connection connection;

	private DAOVehiculoImpl() {
		super();
		dbConnection = new BD1();
                connection = dbConnection.enlace();
//		this.falsaBD = new ArrayList<Vehiculo>();
//		falsaBD.add(new Vehiculo("12345678A","Renault","Zoe","2345FDF"));
//		falsaBD.add(new Vehiculo("12345678A","Renault","Fluence","0000FTL"));
//		falsaBD.add(new Vehiculo("98765432Z","Tesla","3","2422FHT"));
//		falsaBD.add(new Vehiculo("01928375D","Tesla","X","1221FDF"));

	}

	@Override
	public int insertarVehiculo(Vehiculo vehiculo) {

		String sqlQuery = "INSERT INTO vehiculos (marca, modelo, matricula) VALUES (?, ?, ?)";

		try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
			statement.setString(1, vehiculo.getMarca());
			statement.setString(2, vehiculo.getModelo());
			statement.setString(3, vehiculo.getMatricula());

			if (statement.executeUpdate() > 0) {
				return 1;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}

		return 0;
	}

	@Override
	public int eliminarVehiculo(String matricula) {
		String sqlQuery = "DELETE FROM vehiculos WHERE matricula = ?";

		try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
			statement.setString(1, matricula);

			if (statement.executeUpdate() > 0) {
				System.out.println("Vehiculo eliminado exitosamente.");
				return 1;
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return 0;
	}

	@Override
	public int eliminarVehiculos(List<Vehiculo> lstVehiculos) {
		falsaBD.removeAll(lstVehiculos);
		return 0;
	}

	@Override
	public Vehiculo getVehiculo(String matricula) {
		return null;
	}

	@Override
	public List<Vehiculo> getVehiculos() {
		return this.falsaBD;
	}

	public static IDAOVehiculo getInstance() {
		if (dao == null)
			dao = new DAOVehiculoImpl();

		return dao;
	}

	@Override
	public int eliminarVehiculo(Vehiculo vehiculo) {
		// TODO Auto-generated method stub
		return 0;
	}

}
