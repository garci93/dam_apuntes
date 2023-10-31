package DAM.abstracta.modelo;

import java.util.ArrayList;

import DAM.abstracta.DAO.DAOInmueble;
import DAM.abstracta.POJO.Inmueble;
import DAM.abstracta.POJO.Solar;
import DAM.abstracta.POJO.Vivienda;
import DAM.abstracta.interfaces.IAgencia;

public class Agencia implements IAgencia {
	private ArrayList<Inmueble> inmuebles;

    public Agencia() {
        this.inmuebles = DAOInmueble.getInstance().getInmuebles();

    }

	@Override
	public boolean añadeAlquilerInmueble(Inmueble inmueble) {
		// TODO Auto-generated method stub
		return false;
	}

    @Override
    public ArrayList<Inmueble> inmueblesVenta(Float precio) {
        ArrayList<Inmueble> inmueblesVenta = new ArrayList<Inmueble>();
        for(int i=0; i<inmuebles.size(); i++) {
            if(inmuebles.get(i) instanceof Vivienda) {
                Vivienda vivienda = (Vivienda) inmuebles.get(i);
                if(vivienda.getPrecio() < precio) {
                    inmueblesVenta.add(inmuebles.get(i));
                }
            }
            if(inmuebles.get(i) instanceof Solar) {
                Solar solar = (Solar) inmuebles.get(i);
                if(solar.getPrecioTotal() < precio) {
                    inmueblesVenta.add(inmuebles.get(i));
                }
            }
        }
        return inmueblesVenta;
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
