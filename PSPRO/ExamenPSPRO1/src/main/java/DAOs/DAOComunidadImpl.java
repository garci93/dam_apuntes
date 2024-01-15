package DAOs;

import POJOs.Comunidad;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import javax.swing.table.DefaultTableModel;

public class DAOComunidadImpl implements IDAOComunidad {

	private List<Comunidad> falsaBD;
	private static IDAOComunidad dao = null;
	private BD1 dbConnection;
	private Connection connection;

	private DAOComunidadImpl() {
		super();
		dbConnection = new BD1();
                connection = dbConnection.enlace();

	}

	@Override
	public List<Comunidad> getComunidades() {
		return this.falsaBD;
	}

	public static IDAOComunidad getInstance() {
		if (dao == null)
			dao = new DAOComunidadImpl();

		return dao;
	}
        
        public void eliminarComunidad (String codigo){
            //To do
        }

}
