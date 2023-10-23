package DAM.abstracta.POJO;

import DAM.abstracta.enums.ZonaSolar;

public class Solar extends Superficie {
	private ZonaSolar zona;

	public ZonaSolar getZona() {
		return zona;
	}

	public void setZona(ZonaSolar zona) {
		this.zona = zona;
	}
}