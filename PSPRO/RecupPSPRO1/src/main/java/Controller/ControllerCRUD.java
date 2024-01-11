package Controller;




import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import DAOs.BD1;
import DAOs.DAOJugadorImpl;
import POJOs.Jugador;

import Vista.Consulta;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class ControllerCRUD implements ActionListener
{
    private static Consulta vista;
    private static BD1 dbConnection;
	
    public static void mostrarResultado(JTable tablaJugador)
    {
        DefaultTableModel modeloDeDatosTabla = (DefaultTableModel) tablaJugador.getModel();
        List<Jugador> lstJugadores = DAOJugadorImpl.getInstance().getJugadores();
        vista = new Consulta();
        String sqlQuery = "SELECT * FROM jugador";
        dbConnection = new BD1();
        ResultSet rs = dbConnection.ejecutarConsulta(sqlQuery);

        DefaultTableModel modelo=new DefaultTableModel();
        modelo.addColumn("Dorsal");
        modelo.addColumn("Nombre");
        modelo.addColumn("Puntos");
        modelo.addColumn("Rebotes");
        modelo.addColumn("Asistencias");

        try {
                Object[] registroLeido = new Object[5];
                while(rs.next()) {
                        vista.jTextArea1.append (rs.getInt("dorsal"));
                        registroLeido[1] = rs.getString("nombre");
                        registroLeido[2] = rs.getDouble("puntos");
                        registroLeido[3] = rs.getDouble("rebotes");
                        registroLeido[4] = rs.getDouble("asistencias");

                        modelo.addRow(registroLeido);
                }
        } catch (SQLException e) {};
        tablaJugador.setModel(modelo);
        
        vista.setjTextArea1();
        }
	
    public void actionPerformed(ActionEvent e) {
        realizarConsulta(e);
    }
	
    public void realizarConsulta(ActionEvent e){
        //todo
    }
}
