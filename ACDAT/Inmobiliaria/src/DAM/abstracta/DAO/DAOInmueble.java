package DAM.abstracta.DAO;

import java.time.LocalDate;
import java.time.Month;
import java.util.ArrayList;

import DAM.abstracta.POJO.Inmueble;
import DAM.abstracta.POJO.Local;
import DAM.abstracta.POJO.Plaza;
import DAM.abstracta.POJO.Solar;
import DAM.abstracta.POJO.Vivienda;
import DAM.abstracta.enums.TipoContruccion;
import DAM.abstracta.enums.TipoPlaza;
import DAM.abstracta.enums.TipoSolar;



public class DAOInmueble {
	
	private static DAOInmueble dao=null;
	private ArrayList<Inmueble> falsaBD;
	
	
	private DAOInmueble() 
	{
		falsaBD = new ArrayList<Inmueble>();
				
		falsaBD.add(new Solar("C Larga 14",100, 2500,TipoSolar.URBANO));
		falsaBD.add(new Plaza("C Ancha 10",100, 6500,TipoPlaza.PRIVADA));
		falsaBD.add(new Vivienda("C Larga 14",150F,TipoContruccion.NUEVA,2000,4,"4F"));
		falsaBD.add(new Local("C Larga 14",150F,TipoContruccion.NUEVA,3000F));
		
	}
	

	public static DAOInmueble getInstance()
	{ if (dao==null)  dao= new DAOInmueble();
		
		return dao;
	}
	
	
	public ArrayList<Inmueble> getInmuebles()
	{ return falsaBD;
		
	}
	

}
