package ListaTareas;

public class Tarea {
	private String tarea;
	private boolean completada;
	
	public boolean estaCompletada() {
		return this.completada;
	}
	
	public void setCompletada() {
		this.completada = true;
	}
}
