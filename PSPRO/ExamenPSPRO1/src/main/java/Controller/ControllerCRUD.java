package Controller;




import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import DAOs.BD1;
import DAOs.DAOComunidadImpl;
import POJOs.Comunidad;
import POJOs.Vivienda;

import Vista.PantallaInicial;

public class ControllerCRUD
{
	
    private static BD1 dbConnection;
	
	public static void cargarTabla( JTable tablaComunidades)
	{
            DefaultTableModel modeloDeDatosTabla = (DefaultTableModel) tablaComunidades.getModel();
            List<Comunidad> lstComunidades = DAOComunidadImpl.getInstance().getComunidades();
            String sqlQuery = "SELECT * FROM comunidades";
            dbConnection = new BD1();
            ResultSet rs = dbConnection.ejecutarConsulta(sqlQuery);

            DefaultTableModel modelo=new DefaultTableModel();
            modelo.addColumn("Código");
            modelo.addColumn("Ciudad");
        try {
        	Object[] registroLeido = new Object[2];
        	while(rs.next()) {
        		registroLeido[0] = rs.getInt("codigo");
        		registroLeido[1] = rs.getString("ciudad");
        		
        		modelo.addRow(registroLeido);
        	}
        } catch (SQLException e) {};
        tablaComunidades.setModel(modelo);
	}
        
        /*public static void cargarTabla( JTable tablaVehiculos)
	{ //DefaultTableModel modeloDeDatosTabla = (DefaultTableModel) tablaVehiculos.getModel();
		List<Vehiculo> lstVehiculos = DAOVehiculoImpl.getInstance().getVehiculos();
		String sqlQuery = "SELECT * FROM vehiculos";
		BD1 dbConnection = new BD1();
		
		ResultSet rs = dbConnection.ejecutarConsulta(sqlQuery);

		DefaultTableModel modelo=new DefaultTableModel();
		modelo.addColumn("ID");
        modelo.addColumn("Marca");
        modelo.addColumn("Modelo");
        modelo.addColumn("Matricula");
        try {
        	Object[] registroLeido = new Object[4];
        	while(rs.next()) {
        		registroLeido[0] = rs.getString("id");
        		registroLeido[1] = rs.getString("marca");
        		registroLeido[2] = rs.getString("modelo");
        		registroLeido[3] = rs.getString("matricula");
        		
        		modelo.addRow(registroLeido);
        	}
        } catch (SQLException e) {};
        tablaVehiculos.setModel(modelo);
	}*/


	public static void eliminarComunidad(String codigo, JTable tablaComunidades) {
			DAOComunidadImpl.getInstance().eliminarComunidad(codigo);
			cargarTabla(tablaComunidades);
		
	}
	
	
	

}
