package Clases;

public enum Zona {
	PROA(4,9,24),POPA(3,10,23),BABOR(2,6,8),ESTRIBOR(1,5,7);
	
	private int esc1,esc2,esc3;

	private Zona(int esc1, int esc2, int esc3) {
		this.esc1 = esc1;
		this.esc2 = esc2;
		this.esc3 = esc3;
	}
}
