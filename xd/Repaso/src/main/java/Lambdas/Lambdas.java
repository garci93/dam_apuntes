/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Lambdas;

/**
 *
 * @author santi
 */
public class Lambdas {
    
    //LO COMENTADO ABAJO VA EN EL MAIN
    /*
    int numeros[] = {1,2,3,4,5};
    
    System.out.println(promedioArregloEnteros(numeros));

    int factorial = 10;
    System.out.println(calcularFactoria(factorial));

    int numero = 2;
    System.out.println(esPar(numero));

    System.out.println(numeroMayorArray(numeros));

    System.out.println(numeroMenorArray(numeros));

    int numerosRepetidos[] = {2,3,2,2,2,3,3};
    System.out.println(numeroMasRepetido(numerosRepetidos));

    System.out.println(mayorDeTres(2, 3, 1));

    System.out.println(multiplicacion("2", 5));
    */
    
    //METODOS DE LOS EJERCICIOS
    //1. Crear una función anónima que nos permita calcular el promedio de un arreglo de números enteros.
	
	public static int promedioArregloEnteros(int[] arrayNumeros) {
            PromedioArregloEnteros promedioArreglo = (array) -> {
                    int media, suma = 0;
                    for(int i=0; i<array.length; i++) {
                            suma += array[i];
                    }
                    media = suma/array.length;
                    return media;
            };
            return promedioArreglo.mediaArreglo(arrayNumeros);
	}
	
	//2. Crear una función anónima que calcule el factorial dado un número entero.
	
	public static int calcularFactoria(int numero) {
            FactorialNumero factorialNum = (num) -> {
                    int factorial = 1;
                    for(int i=1; i<=num; i++) {
                            factorial *= i;
                    }
                    return factorial;
            };
            return factorialNum.factorial(numero);
	}
	
	//3. Crear una función anónima que permita conocer si un número es par.
	
	public static boolean esPar(int numero) {
            EsPar esPar = (num) -> {
                    if(num%2==0) {return true;}
                    else {return false;}
            };
            return esPar.esPar(numero);	
	}

	//4. Dado un arreglo de números enteros, crear una función anónima que retorne el número mayor.
	
	public static int numeroMayorArray(int[] arrayNumeros) {
            MayorArreglo mayorArreglo = (arregloNumeros) -> {
                int mayorActual = arregloNumeros[0];
                for(int i=0; i<arregloNumeros.length; i++) {
                        if(arregloNumeros[i]>mayorActual) {
                                mayorActual = arregloNumeros[i];
                        }
                }
                return mayorActual;
            };
            return mayorArreglo.numeroMayorArreglo(arrayNumeros);
	}
	
	//5. Dado un arreglo de números enteros, crear una función anónima que retorne el número menor.
	
	public static int numeroMenorArray(int[] arrayNumeros) {
            MenorArreglo menorArreglo = (arregloNumeros) -> {
                    int menorActual = arregloNumeros[0];
                    for(int i=0; i<arregloNumeros.length; i++) {
                            if(arregloNumeros[i]<menorActual) {
                                    menorActual = arregloNumeros[i];
                            }
                    }
                    return menorActual;
            };
            return menorArreglo.numeroMenorArreglo(arrayNumeros);
	}
	
	
	//6. Dado un arreglo de números enteros, crear una función anónima que retorne el número que más se repite.
	
	public static int numeroMasRepetido(int[] arrayNumeros) {
            NumeroMasRepetido numeroMasRepetido = (array) -> {
                    int numeroActual = 0, numero = 0, cantRepetido = 0, cantRepetidoActual = 0;
                    for(int i=0; i<array.length; i++) {
                            numeroActual = array[i];
                            cantRepetidoActual = 0;
                            for(int j=0; j<array.length; j++) {
                                    if(array[i] == array[j]) {
                                            cantRepetidoActual++;
                                    }
                            }
                if (i == 0 || cantRepetidoActual > cantRepetido) {
                    numero = numeroActual;
                    cantRepetido = cantRepetidoActual;
                }
                    }
                    return numero;
            };
            return numeroMasRepetido.numeroMasRepetido(arrayNumeros);
	}
	
	//7. Crear una función anónima que reciba como parámetro 3 numeros enteros. La función retorna el número mayor.
	
	public static int mayorDeTres(int num1, int num2, int num3) {	
            MayorDeTresNumeros mayorDeTresNumeros = (numero1, numero2, numero3) -> {
                if(numero1 > numero2) {
                        if(numero1 > numero3) {
                                return numero1;
                        }
                        else {
                                return numero3;
                        }	
                }
                else {
                        if(numero2 > numero3) {
                                return numero2;
                        }
                        else{
                                return numero3;
                        }
                }
            };
            return mayorDeTresNumeros.mayorDeTresNumeros(num1, num2, num3);
	}
	
	
	//8. Crear una función anónima que reciba dos parámetros, un String y un numero entero. La función retorna un String el cual será el resultado de multiplicar ambos parámetros.
	
	public static String multiplicacion(String num1, int num2) {
            MultiplicarParametros multiplicar = (numero1, numero2) -> {
                    int numero = Integer.parseInt(num1);
                    return ""+numero*numero2;
            };
            return multiplicar.multiplicar(num1, num2);
	}
}
