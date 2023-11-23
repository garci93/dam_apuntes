package Controller;




import java.util.List;

import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import DAOs.DAOClienteImpl;
import Recursos.Cliente;
import Vista.PanelCRUD;





public class ControllerCRUD
{
	
	
	public static void cargarTabla( JTable tablaClientes)
	{ //DefaultTableModel modeloDeDatosTabla = (DefaultTableModel) tablaClientes.getModel();
		List<Cliente> lstClientes = DAOClienteImpl.getInstance().getClientes();
		
		DefaultTableModel modelo=new DefaultTableModel();
	 
	 
	 modelo.addColumn("Marca");

	 modelo.addColumn("Modelo");

	 modelo.addColumn("Matricula");

	
    
   
	 Object[] registroLeido = new Object [3];
	 
	 for(Cliente Cliente:lstClientes)

	 {	 

			registroLeido[0]= Cliente.getMarca();

			registroLeido[1]= Cliente.getModelo();

			registroLeido[2]=  Cliente.getMatricula();
	 



		 modelo.addRow(registroLeido);

	 }
	 
	 tablaClientes.setModel(modelo);
	}
	
	
	public static boolean insertarCliente( PanelCRUD frmCliente, JTable tablaClientes)
	{ boolean insertado=false;
	Cliente Cliente=new Cliente();
	 
	 
	 
	 Cliente.setMarca(frmCliente.getTxtMarca().getText());

	 Cliente.setModelo(frmCliente.getTxtModelo().getText());

	 Cliente.setMatricula(frmCliente.getTxtMatricula().getText());
	 
		if (DAOClienteImpl.getInstance().insertarCliente(Cliente)!=0)
		{insertado=true;
		cargarTabla( tablaClientes);
		}
     return insertado;		
	}
	
	
	

}
