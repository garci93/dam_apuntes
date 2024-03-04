

import java.awt.BorderLayout;
import java.awt.Window;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;

//Marco con lámina y botones------------------------------------------------------------------------------

class Ventana extends JFrame{
	
	private static final int NUM_MOVIMIENTOS = 1000;
	private PanelRebote zonaRebote;
	JButton btnNuevaPelota, btnSalir;
	
	public Ventana(){
		
		setBounds(600,300,400,350);
		
		setTitle ("Juego pelotas");
		
		zonaRebote=new PanelRebote();
		
		add(zonaRebote, BorderLayout.CENTER);
		
		JPanel zonaBotones=new JPanel();
		
		btnNuevaPelota = new JButton("Nueva pelota");
		zonaBotones.add(btnNuevaPelota);
		btnNuevaPelota.addActionListener( new ActionListener(){
			
			public void actionPerformed(ActionEvent evento){
				
				lanzarJuego();
			}
			
		});
		
		btnSalir = new JButton("Salir");
		zonaBotones.add(btnSalir);
		btnSalir.addActionListener( new ActionListener(){
			
			public void actionPerformed(ActionEvent evento){
				
				System.exit(0);
				
			}
			
		});
		
		add(zonaBotones, BorderLayout.SOUTH);
	}
	
	
	
	
	
	
	
	
	public void lanzarJuego () {
		
					
			Pelota pelota=new Pelota(zonaRebote);//pasarle zonarebote y que se pinte a sí misma
			
			zonaRebote.add(pelota);
			
			for (int i=1; i<=NUM_MOVIMIENTOS; i++){
				
				pelota.paint();
				
				//zonaRebote.paint(zonaRebote.getGraphics());//borrar y que paint sea llamado desde update o update desde un paint de pelota
				
				try {
					Thread.sleep(5);
				} catch (InterruptedException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
			}
			
		
		
	}
	
	
	
	
}
