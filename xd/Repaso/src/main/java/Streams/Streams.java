/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Streams;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

/**
 *
 * @author santi
 */
public class Streams {
    
    
    //LO COMENTADO ABAJO VA EN EL MAIN
    /*
    List<Curso> cursos = new ArrayList<Curso>();
		
    cursos.add(new Curso("Cursos profesional de Java", 6.5f, 50, 200 ));
    cursos.add(new Curso("Cursos profesional de Python", 8.5f, 60, 800 ));
    cursos.add(new Curso("Cursos profesional de DB", 4.5f, 70, 700 ));
    cursos.add(new Curso("Cursos profesional de Android", 7.5f, 10, 400 ));
    cursos.add(new Curso("Cursos profesional de Escritura", 1.5f, 10, 300 ));


    System.out.println(cantidadCursosMayorCincoHoras(cursos));

    System.out.println(cantidadCursosMenorDosHoras(cursos));

    tituloCursoCantidadVideoMayorCincuenta(cursos);

    tituloTresCursosMayorDuracion(cursos);

    duracionTotalCursos(cursos);

    System.out.println(duracionTotalCursos(cursos));

    librosMayorDuracionAPromedio(cursos);

    cursosCantidadAlumnosMenorQuinientos(cursos);

    cursoMayorDuracion(cursos);

    System.out.println(titulosCursos(cursos));
    
    */   
    
    //METODOS DE LOS EJERCICIOS
    
    //1. Obtener la cantidad de cursos con una duración mayor a 5 horas
	
    public static long cantidadCursosMayorCincoHoras(List<Curso> lista) {
            return lista.stream().filter( c -> c.getDuracion()>5).count();
    }


    //2. Obtener la cantidad de cursos con una duración menor a 2 horas.

    public static long cantidadCursosMenorDosHoras(List<Curso> lista) {
            return lista.stream().filter( c -> c.getDuracion()<2).count();
    }


    //3. Listar el título de todos aquellos cursos con una cantidad de vídeos mayor a 50.

    public static void tituloCursoCantidadVideoMayorCincuenta(List<Curso> lista) {
            lista.stream().filter(c -> c.getVideos() > 50).map(Curso::getTitulo).forEach(System.out::println);
    }


    //4. Mostrar en consola el título de los 3 cursos con mayor duración.

    public static void tituloTresCursosMayorDuracion(List<Curso> lista) {
            lista.stream().sorted(Comparator.comparing(Curso::getDuracion).reversed()).limit(3).map(Curso::getTitulo).forEach(System.out::println);
    }


    //5. Mostrar en consola la duración total de todos los cursos.

    public static double duracionTotalCursos(List<Curso> lista) {
            return lista.stream().mapToDouble(Curso::getDuracion).sum();
    }


    //6. Mostrar en consola todos aquellos libros que superen el promedio en cuanto a duración se refiere.

    public static void librosMayorDuracionAPromedio(List<Curso> lista) {
            double promedioDuracion = lista.stream().mapToDouble(Curso::getDuracion).average().orElse(0);
            lista.stream().filter(curso -> curso.getDuracion() > promedioDuracion).forEach(curso -> System.out.println(curso.getTitulo()));
    }


    //7. Mostrar en consola la duración de todos aquellos cursos que tengan una cantidad de alumnos inscritos menor a 500.


    public static void cursosCantidadAlumnosMenorQuinientos(List<Curso> lista) {
            lista.stream().filter(curso -> curso.getAlumnos() < 500).forEach(curso -> System.out.println(curso.getDuracion()));
    }



    //8. Obtener el curso con mayor duración

    public static void cursoMayorDuracion(List<Curso> lista) {
             Optional<Curso> cursoConMayorDuracion = lista.stream().max(Comparator.comparingDouble(Curso::getDuracion));
             cursoConMayorDuracion.ifPresent(curso -> System.out.println(curso.getTitulo() + " - " + curso.getDuracion()));
    }


    //9. Crear una lista de Strings con todos los títulos de los cursos.

    public static String titulosCursos(List<Curso> lista) {
            List<String> titulosCursos = lista.stream().map(Curso::getTitulo).collect(Collectors.toList());
            String resultado = String.join(", ", titulosCursos);
            return resultado;
    }

}
