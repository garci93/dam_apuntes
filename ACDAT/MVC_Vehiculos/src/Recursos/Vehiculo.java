package Recursos;



public class Vehiculo {


private String marca;

private String dni;

private String modelo;

private String matricula;

public Vehiculo() {
	

}


//TODO: AÑADIR CAMPO PROPIETARIO
public Vehiculo(String dni, String marca, String modelo, String matricula) {
	this.dni = dni;
	this.marca = marca;
	this.modelo = modelo;
	this.matricula = matricula;
}

public String getDni() {
	return dni;
}


public void setDni(String dni) {
	this.dni = dni;
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