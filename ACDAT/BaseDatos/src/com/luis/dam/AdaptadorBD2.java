package com.luis.dam;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;


public class AdaptadorBD2 {
	public static final String KEY_IDFILA = "_id";
	public static final String KEY_NOMBRE = "nombre";
	public static final String KEY_EMAIL = "email";
	private static final String TAG = "AdaptadorBD";
	private static final String NOMBRE_BASEDATOS = "MiBD";
	private static final String TABLA_BASEDATOS = "miembros";
	private static final int VERSION_BASEDATOS = 1;
	private static final String CREAR_BASEDATOS = "create table contactos (_id integer primary key autoincrement, "
			+ "nombre text not null, email text not null);";
	private final Context context;
	private DatabaseHelper DBHelper;
	private SQLiteDatabase db;

	public AdaptadorBD2(Context ctx) {
		this.context = ctx;
		DBHelper = new DatabaseHelper(context);
	}

	private static class DatabaseHelper extends SQLiteOpenHelper {
		DatabaseHelper(Context context) {
			super(context, NOMBRE_BASEDATOS, null, VERSION_BASEDATOS);
		}

		@Override
		public void onCreate(SQLiteDatabase db) {
			try {
				db.execSQL(CREAR_BASEDATOS);
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}

		@Override
		public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
			Log.w(TAG, "Actualizando base de datos de versión " + oldVersion + " a "
					+ newVersion + ", lo que destruirá todos los viejos datos");
			db.execSQL("DROP TABLE IF EXISTS contactos");
			onCreate(db);
		}
	}

	// ---abrir la base de datos---
	public AdaptadorBD2 abrir() throws SQLException {
		db = DBHelper.getWritableDatabase();
		return this;
	}

	// ---cerrar la base de datos---
	public void cerrar() {
		DBHelper.close();
	}

	// ---insertar un contacto en la base de datos---
	public long insertarContacto(String nombre, String email) {
		ContentValues valoresIniciales = new ContentValues();
		valoresIniciales.put(KEY_NOMBRE, nombre);
		valoresIniciales.put(KEY_EMAIL, email);
		return db.insert(TABLA_BASEDATOS, null, valoresIniciales);
	}

	// ---borrar un contacto en concreto---
	public boolean borrarContacto(long idFila) {
		return db.delete(TABLA_BASEDATOS, KEY_IDFILA + "=" + idFila, null) > 0;
	}

	// ---recuperar todos los contactos---
	public Cursor obtenerTodosLosContactos() {
		return db.query(TABLA_BASEDATOS, new String[] { KEY_IDFILA, KEY_NOMBRE,
				KEY_EMAIL }, null, null, null, null, null);
	}

	// ---recuperar un contacto en concreto---
	public Cursor obtenerContacto(long idFila) throws SQLException {
		Cursor mCursor = db.query(true, TABLA_BASEDATOS, new String[] {
				KEY_IDFILA, KEY_NOMBRE, KEY_EMAIL }, KEY_IDFILA + "=" + idFila,
				null, null, null, null, null);
		if (mCursor != null) {
			mCursor.moveToFirst();
		}
		return mCursor;
	}

	// ---actualizar un contacto---
	public boolean actualizarContacto(long idFila, String name, String email) {
		ContentValues args = new ContentValues();
		args.put(KEY_NOMBRE, name);
		args.put(KEY_EMAIL, email);
		return db.update(TABLA_BASEDATOS, args, KEY_IDFILA + "=" + idFila, null) > 0;
	}
}