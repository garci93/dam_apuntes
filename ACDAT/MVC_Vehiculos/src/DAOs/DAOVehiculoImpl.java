package DAOs;


import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import Recursos.Cliente;
import Recursos.Vehiculo;




public class DAOVehiculoImpl implements IDAOVehiculo {
	
	private List<Vehiculo> falsaBD;
	private static IDAOVehiculo dao=null; 

	private DAOVehiculoImpl() {
		super();
		this.falsaBD = new ArrayList<Vehiculo>();
		falsaBD.add(new Vehiculo("12345678A","Renault","Zoe","2345FDF"));
		falsaBD.add(new Vehiculo("12345678A","Renault","Fluence","0000FTL"));
		falsaBD.add(new Vehiculo("98765432Z","Tesla","3","2422FHT"));
		falsaBD.add(new Vehiculo("01928375D","Tesla","X","1221FDF"));
		
	}

	@Override
	public int insertarVehiculo(Vehiculo vehiculo) {
//		for(Vehiculo v : falsaBD) {
//			for(Cliente c : DAOClienteImpl.getClientes())
//			if (v.getDni())
//		}
		//TODO: comprobar que el propietario está registrado
		falsaBD.add(vehiculo);
		
		return 1;
	}

	

	@Override
	public int eliminarVehiculo(String matricula) {
		falsaBD.
		falsaBD.remove(matricula);
		return 0;
	}

	@Override
	public int eliminarVehiculos(List<Vehiculo> lstVehiculos) {
		falsaBD.removeAll(lstVehiculos);
		return 0;
	}

	@Override
	public Vehiculo getVehiculo(String matricula) {
		for(Vehiculo v : falsaBD){
			if (v.getMatricula().equals(matricula))
				return v;
		};
		return null;
	}

	@Override
	public List<Vehiculo> getVehiculos() {
		return this.falsaBD;
	}

	
	public static IDAOVehiculo getInstance() {
	  if (dao== null) dao =new DAOVehiculoImpl();
	  
		return dao;
	}

	@Override
	public int eliminarVehiculo(Vehiculo vehiculo) {
		// TODO Auto-generated method stub
		return 0;
	}

}
