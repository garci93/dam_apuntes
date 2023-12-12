package Controller;




import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import DAOs.BD1;
import DAOs.DAOVehiculoImpl;
import Recursos.Vehiculo;
import Vista.PanelCRUD;





public class ControllerCRUD
{
	
	
	public static void cargarTabla( JTable tablaVehiculos)
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
	}
	
	
	public static boolean insertarVehiculo( PanelCRUD frmVehiculo, JTable tablaVehiculos)
	{ boolean insertado=false;
	Vehiculo vehiculo=new Vehiculo();
	 
	 
	 
	 vehiculo.setMarca(frmVehiculo.getTxtMarca().getText());

	 vehiculo.setModelo(frmVehiculo.getTxtModelo().getText());

	 vehiculo.setMatricula(frmVehiculo.getTxtMatricula().getText());
	 
		if (DAOVehiculoImpl.getInstance().insertarVehiculo(vehiculo)!=0)
		{insertado=true;
		cargarTabla( tablaVehiculos);
		}
     return insertado;		
	}


	public static void eliminarVehiculo(String matricula, JTable tablaVehiculos) {
			DAOVehiculoImpl.getInstance().eliminarVehiculo(matricula);
			cargarTabla(tablaVehiculos);
			System.out.println("XD");
		
	}
	
	
	

}
