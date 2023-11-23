package DAOs;


import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import Recursos.Cliente;
import Recursos.Vehiculo;




public class DAOClienteImpl implements IDAOCliente {
	
	private List<Cliente> falsaBD;
	private static IDAOCliente dao=null; 

	private DAOClienteImpl() {
		super();
		this.falsaBD = new ArrayList<Cliente>();
		falsaBD.add(new Cliente("12345678A","Pepe"));
		falsaBD.add(new Cliente("98765432Z","Ana"));
		falsaBD.add(new Cliente("01928375D","Juan"));
		
	}

	@Override
	public int insertarCliente(Cliente cliente) {
		falsaBD.add(cliente);
		
		return 1;
	}

	

	@Override
	public int eliminarCliente(String dni) {
		falsaBD.remove(dni);
		return 0;
	}

	@Override
	public int eliminarClientes(List<Cliente> lstClientes) {
		falsaBD.removeAll(lstClientes);
		return 0;
	}

	@Override
	public Cliente getCliente(String dni) {
		for(Cliente c : falsaBD){
			if (c.getDni().equals(dni))
				return c;
		};
		return null;
	}

	@Override
	public List<Cliente> getClientes() {
		return this.falsaBD;
	}

	
	public static IDAOCliente getInstance() {
	  if (dao== null) dao =new DAOClienteImpl();
	  
		return dao;
	}

	@Override
	public int eliminarCliente(Cliente cliente) {
		falsaBD.remove(cliente);
		return 0;
	}

}
