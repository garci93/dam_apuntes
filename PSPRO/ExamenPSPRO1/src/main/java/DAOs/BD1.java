/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package DAOs;

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
    static String login="examen";
    static String password="examen";  
    static String url="jdbc:mysql://localhost/phpmyadmin/"+bd;
    

    
    public static Connection enlace () 
{
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            conn=DriverManager.getConnection(url,login,password);
        } catch (SQLException ex) {
          System.out.println("Excepcion en la conexión");
        } catch (ClassNotFoundException ex) {
           System.out.println("No se encuentra la clase");
        }
    return conn;
}
    
     static ResultSet consulta() {
         conn=enlace();
        try {
            st=conn.createStatement();
        } catch (SQLException ex) {
            System.out.println("excepcion");
        }
        try {
            rs=st.executeQuery("consulta");
        } catch (SQLException ex) {
           System.out.println("error en la query");
        }
        
        return rs;
    }
     
     public static ResultSet ejecutarConsulta(String consulta) {
        conn=enlace();
        try {
            st=conn.createStatement();
        } catch (SQLException ex) {
            System.out.println("excepcion");
        }
        try {
            rs=st.executeQuery(consulta);
        } catch (SQLException ex) {
           System.out.println("error en la query");
        }
        
        return rs;
    }


     public static void imprimirConsulta(ResultSet rs){
        try {
            while (rs.next()){
                System.out.print(rs.getInt(1)+"    ");
                System.out.print(rs.getString("Nombre")+"     ");
                System.out.print(rs.getString("Apellido1")+"     ");
                System.out.println(rs.getString("Apellido2"));
            }
        } catch (SQLException ex) {
            System.out.println("Error en el resultset");
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
    public static void main(String[] args) {
        
        
        conn=enlace();
        rs=consulta();
        imprimirConsulta(rs);
        cerrarSesion();
        
    }
}
