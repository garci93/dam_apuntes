package com.luis.dam;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;



import android.app.Activity;
import android.database.Cursor;
import android.os.Bundle;
import android.widget.Toast;

public class BaseDatosActivity2 extends Activity {
	/** Llamada cuando la activity es creada por primera vez. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);

		try {
			String destPath = "/data/data/" + getPackageName()
					+ "/databases/MiBD";
			File f = new File(destPath);
			if (!f.exists()) {
				CopyDB(getBaseContext().getAssets().open("contactos2"),
						new FileOutputStream(destPath));
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
		AdaptadorBD2 db = new AdaptadorBD2(this);
		// ---obtener todos los contactos---
		db.abrir();
		Cursor c = db.obtenerTodosLosContactos();
		if (c.moveToFirst()) {
			do {
				DisplayContact(c);
			} while (c.moveToNext());
		}
		db.cerrar();
	}

	public void CopyDB(InputStream inputStream, OutputStream outputStream)
			throws IOException {
		// ---copy 1K bytes at a time---
		byte[] buffer = new byte[1024];
		int length;
		while ((length = inputStream.read(buffer)) > 0) {
			outputStream.write(buffer, 0, length);
		}
		inputStream.close();
		outputStream.close();
	}

	public void DisplayContact(Cursor c) {
		Toast.makeText(
				this,
				"id: " + c.getString(0) + "\n" + "Name: " + c.getString(1)
						+ "\n" + "Email: " + c.getString(2), Toast.LENGTH_LONG)
				.show();
	}
}