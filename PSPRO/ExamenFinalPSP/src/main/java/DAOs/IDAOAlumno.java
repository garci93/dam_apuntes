/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package DAOs;

import POJOs.Alumno;
import java.sql.ResultSet;
import java.util.List;

/**
 *
 * @author dam
 */
interface IDAOAlumno {
    public List<Alumno> getAlumnos();
}
