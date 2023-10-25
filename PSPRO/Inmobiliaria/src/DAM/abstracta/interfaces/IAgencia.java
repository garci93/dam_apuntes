package DAM.abstracta.interfaces;

import java.util.ArrayList;

import DAM.abstracta.POJO.Inmueble;

public interface IAgencia {

	public boolean añadeAlquilerInmueble(Inmueble inmueble);
	public ArrayList<Inmueble> inmueblesVenta(Float precio);
	public ArrayList<Inmueble> SegundaMano(Float superficie);
	public int solaresRusticos();
	public IAgencia fusion(IAgencia agencia);
}