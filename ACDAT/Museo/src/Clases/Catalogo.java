package Clases;

import java.util.ArrayList;

public class Catalogo {
	private ArrayList<Obra> obras;

	public void aniadeObra(Obra ob) {
		if (existeObra(ob))
			System.out.println("La obra ya está en el museo");
		else {
			obras.add(ob);
			System.out.println("Obra añadida con éxito");
		}
	}
	
	public void eliminaObra (int numeroInv) {
		boolean encontrada = false;
		for (Obra o :this.obras) {
			if (o.getNumeroInv() == numeroInv) {
				encontrada = true;
				obras.remove(o);
				System.out.println("Obra eliminada con éxito");
				break;
			}
		}
		if (encontrada = false) System.out.println("No se ha encontrado la obra con el número especificado");
	}
	
	public void buscaObra (int numeroInv) {
		boolean encontrada = false;
		for (Obra o :this.obras) {
			if (o.getNumeroInv() == numeroInv) {
				encontrada = true;
				System.out.println(o.toString());
			}
		}
		if (encontrada = false) System.out.println("No se ha encontrado la obra con el número especificado");
	}
	
	public double superficie () {
		double res=0;
		for (Obra o :this.obras) {
			if (o instanceof Pintura) res+=((Pintura) o).getAlto()*((Pintura) o).getAncho();
		}
		return res;
	}
	
	public int masAlta() {
		int maxAltura=0;
		for (Obra o :this.obras) {
			if (o instanceof Escultura && (((Escultura) o).getAltura()) > maxAltura) maxAltura = ((Escultura) o).getAltura();
		}
		return maxAltura;
	}
	
	public Boolean existeObra(Obra ob) {
		boolean res = false;
		for (Obra o :this.obras) {
			if (o.equals(ob))
			{
				res = true;
				break;
			}
		}
		return res;
	}
	
	
}
