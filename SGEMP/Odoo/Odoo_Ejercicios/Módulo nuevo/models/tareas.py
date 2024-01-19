# models/tareas.py
from odoo import models, fields

class Tarea(models.Model):
    _name = 'mi_modulo_tareas.tarea'
    _description = 'Tareas Pendientes'

    nombre = fields.Char(string='Título', required=True)
    descripcion = fields.Text(string='Descripción')
    fecha_vencimiento = fields.Date(string='Fecha de Vencimiento')
    estado = fields.Selection([
        ('pendiente', 'Pendiente'),
        ('en_progreso', 'En Progreso'),
        ('completada', 'Completada'),
    ], string='Estado', default='pendiente')
