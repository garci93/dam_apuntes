package DAM.abstracta.modelo;

import java.util.ArrayList;

import DAM.abstracta.POJO.Inmueble;
import DAM.abstracta.interfaces.IAgencia;

public class Agencia implements IAgencia {
	public Agencia (ArrayList<Inmueble> inmuebles) {
		//todo
	}

	@Override
	public boolean añadeAlquilerInmueble(Inmueble inmueble) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public ArrayList<Inmueble> inmueblesVenta(Float precio) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public ArrayList<Inmueble> SegundaMano(Float superficie) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public int solaresRusticos() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public IAgencia fusion(IAgencia agencia) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public String toString() {
		//todo
		return "Agencia []";
	}
	
	
}
