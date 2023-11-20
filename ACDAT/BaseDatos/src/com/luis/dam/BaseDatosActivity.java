package com.luis.dam;


import android.app.Activity;
import android.database.Cursor;
import android.os.Bundle;
import android.widget.Toast;
public class BaseDatosActivity extends Activity {
/** Llamado cuando la activity es creada por primera vez. */
@Override
public void onCreate(Bundle savedInstanceState) {
super.onCreate(savedInstanceState);
setContentView(R.layout.main);

AdaptadorBD db = new AdaptadorBD(this);


/*//---a�adir contactos---
db.abrir();
long id = db.insertarContacto("Pedro V�zquez Arriba", "pedrovazquez@cooperantes.com");
id = db.insertarContacto("Mar�a Sampietro", "mariasamp@cooperantes.com");
db.cerrar();

}*/
/*//---obtener todos los contactos---
db.abrir();
Cursor c = db.obtenerTodosLosContactos();
if (c.moveToFirst())
{
do {
DisplayContact(c);
} while (c.moveToNext());
}
db.cerrar();
}*/

/*//---obtener un contacto---
db.abrir();
Cursor c = db.obtenerContacto(2);
if (c.moveToFirst())
DisplayContact(c);
else
Toast.makeText(this, "No se ha encontrado el contacto", Toast.LENGTH_LONG).show();
db.cerrar();
}*/

/*//---actualizar contacto---
db.abrir();
if (db.actualizarContacto(1, "Arnaldo Aramburu", "arnaldoaramburu@gmail.com"))
Toast.makeText(this, "Actualizaci�n Correcta.", Toast.LENGTH_LONG).show();
else
Toast.makeText(this, "Actualizaci�n Ha fallado.", Toast.LENGTH_LONG).show();
db.cerrar();
}*/

//---borrar un contacto---
db.abrir();
if (db.borrarContacto(3))
Toast.makeText(this, "Registro eliminado.", Toast.LENGTH_LONG).show();
else
Toast.makeText(this, "Eliminaci�n registro ha fallado.", Toast.LENGTH_LONG).show();
db.cerrar();
}

public void DisplayContact(Cursor c)
{
Toast.makeText(this,
"id: " + c.getString(0) + "\n" +
"Nombre: " + c.getString(1) + "\n" +
"Email: " + c.getString(2),
Toast.LENGTH_LONG).show();
}
}