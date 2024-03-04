package Controller;




import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import DAOs.BD1;
import DAOs.DAOAlumnoImpl;
import POJOs.Alumno;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.PreparedStatement;

public class ControllerCRUD implements ActionListener
{
    private static Consulta vista;
    private static BD1 dbConnection;
	
    public static void mostrarResultado(JTable tablaJugador)
    {
        DefaultTableModel modeloDeDatosTabla = (DefaultTableModel) tablaJugador.getModel();
        vista = new Consulta();
        String sqlQuery = "SELECT * FROM alumno";
        dbConnection = new BD1();
        ResultSet rs = dbConnection.ejecutarConsulta(sqlQuery);

        DefaultTableModel modelo=new DefaultTableModel();
        modelo.addColumn("DNI");
        modelo.addColumn("Nombre");


        try {
                Object[] registroLeido = new Object[2];
                while(rs.next()) {
                        registroLeido[1] = rs.getString("dni");
                        registroLeido[2] = rs.getDouble("nombre");

                        modelo.addRow(registroLeido);
                }
        } catch (SQLException e) {};
        tablaJugador.setModel(modelo);
        
        }
	
    public void actionPerformed(ActionEvent e) {
        realizarConsulta(e);
    }
	
    public void realizarConsulta(ActionEvent e){
        //todo
    }
    
    
    
    public void anadirAlumno(String dni, String nombre) {
        String sqlQuery = "INSERT INTO alumnos ('dni','nombre') VALUES ('"+dni+"','"+nombre+"');";
        dbConnection.executeCommand(sqlQuery);
    }
    
    public void modificarAlumno(String dni, String nombre) {
        String sqlQuery = "UPDATE 'alumnos' SET 'dni' = '"+dni+"', `nombre` = '"+nombre+"'  WHERE ('dni' = '"+dni+"');";
        dbConnection.executeCommand(sqlQuery);
    }
    
    public double mediaAlumno(String dni) {
        String sqlQuery = "SELECT AVG(`nota`) FROM `examenfinal`.`notas` WHERE (`dni` = '"+dni+"');";
        dbConnection.executeCommand(sqlQuery);
    }
}
