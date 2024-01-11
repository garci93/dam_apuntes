package DAOs;

import POJOs.Jugador;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import javax.swing.table.DefaultTableModel;

public class DAOJugadorImpl implements IDAOJugador {

	private List<Jugador> falsaBD;
	private static IDAOJugador dao = null;
	private BD1 dbConnection;
	private Connection connection;

	private DAOJugadorImpl() {
		super();
		dbConnection = new BD1();
                connection = dbConnection.enlace();
	}

	@Override
	public List<Jugador> getJugadores() {
		return this.falsaBD;
	}

	public static IDAOJugador getInstance() {
		if (dao == null)
			dao = new DAOJugadorImpl();

		return dao;
	}

}
