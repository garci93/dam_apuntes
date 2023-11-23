package DAOs;


import java.util.List;

import Recursos.Cliente;



	public interface IDAOCliente 
	{ public int insertarCliente(Cliente cliente);
	  public int eliminarCliente(Cliente cliente);
	  public int eliminarCliente(String dni);
	  public int eliminarClientes(List<Cliente> lstClientes);
	  public Cliente getCliente(String dni);
	  public  List<Cliente> getClientes();
 


  
	
	

}
