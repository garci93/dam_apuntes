package DAM.abstracta.DAO;

import java.time.LocalDate;
import java.time.Month;
import java.util.ArrayList;

import DAM.abstracta.POJO.Inmueble;
import DAM.abstracta.POJO.LocalComercial;
import DAM.abstracta.POJO.PlazaGaraje;
import DAM.abstracta.POJO.Solar;
import DAM.abstracta.POJO.Vivienda;
import DAM.abstracta.enums.TipoConstruccion;
import DAM.abstracta.enums.TipoPlaza;
import DAM.abstracta.enums.ZonaSolar;



public class DAOInmueble {
	
	private static DAOInmueble dao=null;
	private ArrayList<Inmueble> falsaBD;
	
	
	private DAOInmueble() 
	{
		falsaBD = new ArrayList<Inmueble>();
				
		falsaBD.add(new Solar("C Larga 14",100, 2500,ZonaSolar.URBANA));
		falsaBD.add(new PlazaGaraje("C Ancha 10",100, 6500,TipoPlaza.PRIVADA));
		falsaBD.add(new Vivienda("C Larga 14",150F,TipoConstruccion.NUEVA,2000,4,"4F"));
		falsaBD.add(new LocalComercial("C Larga 14",150F,TipoConstruccion.NUEVA,3000F));
	}
	
	public static DAOInmueble getInstance()
	{ if (dao==null)  dao= new DAOInmueble();
		
		return dao;
	}
	
	
	public ArrayList<Inmueble> getInmuebles()
	{ return falsaBD;
		
	}
}
