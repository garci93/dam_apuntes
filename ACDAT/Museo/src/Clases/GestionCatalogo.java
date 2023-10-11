package Clases;

import java.util.ArrayList;

public class GestionCatalogo {
	private ArrayList<Obra> catalogo;
	
	public GestionCatalogo() {
		catalogo = DAOObras.getInstance().getObras();
	}

	@Override
	public String toString() {
		return catalogo.toString();
	}
}
