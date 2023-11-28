package Recursos;



public class Vehiculo {


private String marca;

private String cliente_id;

private String modelo;

private String matricula;

public Vehiculo() {
	

}


//TODO: AÑADIR CAMPO PROPIETARIO
public Vehiculo(String cliente_id, String marca, String modelo, String matricula) {
	this.cliente_id = cliente_id;
	this.marca = marca;
	this.modelo = modelo;
	this.matricula = matricula;
}

public String getClienteId() {
	return cliente_id;
}


public void setClienteId(String cliente_id) {
	this.cliente_id = cliente_id;
}


public String getMarca() {
	return marca;
}

public void setMarca(String marca) {
	this.marca = marca;
}

public String getModelo() {
	return modelo;
}

public void setModelo(String modelo) {
	this.modelo = modelo;
}

public String getMatricula() {
	return matricula;
}

public void setMatricula(String matricula) {
	this.matricula = matricula;
}

@Override
public String toString() {
	return "Vehiculo [Marca: " + marca + "\nModelo: " + modelo + "\nMatrícula: " + matricula + "]";
}






}