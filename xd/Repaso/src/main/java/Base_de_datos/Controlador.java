/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Base_de_datos;

import java.util.List;

/**
 *
 * @author santi
 */
public class Controlador {
    
    public static boolean insertarVehiculo(String marca, String modelo, String matricula, String idUsuario)
    { 
        boolean insertado=false;

        Vehiculo vehiculo=new Vehiculo();

         vehiculo.setMarca(marca);

         vehiculo.setModelo(modelo);

         vehiculo.setMatricula(matricula);

         vehiculo.setIdUsuario(Integer.parseInt(idUsuario));

        if (EjemploDAOVehiculo.getInstance().insertarVehiculo(vehiculo)!=0)
        {
            insertado=true;
        }

         return insertado;		
    }
    
    
    public static boolean insertarUsuario(String nombre, String apellido) {

        boolean insertado = false;

        Usuario usuario = new Usuario(nombre, apellido);

        if(EjemploDAOUsuario.getInstance().insertarUsuario(usuario)!=0) {
                insertado=true;
        }

        return insertado;
    }
    
    public static List<Usuario> obtenerUsuarios() {
        List<Usuario> usuarios = EjemploDAOUsuario.getInstance().getUsuarios();

        return usuarios;
    }
       
    
    
    public static boolean eliminarUsuario(String nombre) {
        boolean eliminado = false;

        List<Usuario> usuarios = EjemploDAOUsuario.getInstance().getUsuarios();
        List<Vehiculo> vehiculos = EjemploDAOVehiculo.getInstance().getVehiculos();

        int idUsuario = -1;
        for(int i=0; i<usuarios.size(); i++) {
            if(usuarios.get(i).getNombre().equals(nombre)) {
                idUsuario = usuarios.get(i).getId();
            }
        }
        if(idUsuario == -1) {
            System.out.println("Usuario no encontrado");
        }
        else {
            if(EjemploDAOVehiculo.getInstance().eliminarVehiculo(idUsuario)!=0) {
                System.out.println("Vehiculos eliminados");

                if(EjemploDAOUsuario.getInstance().eliminarUsuario(nombre)!=0) {
                    System.out.println("Usuario eliminado");
                    eliminado=true;
                }
            }
        }
        return eliminado;
    }
    
    
    
	
}
