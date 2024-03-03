package DAOs;

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 *
 * @author USUARIO
 */
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;


public class BD1 {

    static Connection conn=null;
    static Statement st=null;
    static ResultSet rs=null;
    static String bd="examen";
    static String login="root";
    static String password="";  
    static String url="jdbc:mysql://localhost/"+bd;
    
//    public BD1() {
//        conn=enlace();
//        rs=consulta();
//        imprimirConsulta(rs);
//        cerrarSesion();
//    }

    
    public static Connection enlace () 
    {
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            conn=DriverManager.getConnection(url,login,password);
            System.out.println("Conectado");
        } catch (SQLException ex) {
            System.out.println("Excepcion en la conexion");
        } catch (ClassNotFoundException ex) {
            System.out.println("No se encuentra la clase");
        }
        return conn;
    }
    
    public static ResultSet consulta() {
        conn = enlace();
        try {
            st=conn.createStatement();
        } catch (SQLException ex) {
            System.out.println("excepcion");
        }
        try {
            rs=st.executeQuery("select * from comunidad");
        } catch (SQLException ex) {
           System.out.println("error en la query");
           ex.printStackTrace();
        }
        
        return rs;
    }
    
    public static void executeCommand(String command) {
        conn = enlace();
        try {
            st=conn.createStatement();
        } catch (SQLException ex) {
            System.out.println("excepcion al crear statement");
        }
        try {
            st.executeUpdate(command);
        } catch (SQLException ex) {
           System.out.println("error en el comando");
           ex.printStackTrace();
        }
    }
    
     public static void cerrarSesion() {
        try {
            rs.close();
            st.close();
            conn.close();
        } catch (SQLException ex) {
            Logger.getLogger(BD1.class.getName()).log(Level.SEVERE, null, ex);
        }
     }
}