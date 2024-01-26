from odoo import models, fields, api

class Tarea(models.Model):
    _name = 'tareas.tarea'
    _description = 'Tareas'

    name = fields.Char(string="Nombre de tarea", required=True)
    description = fields.Text(string="Descripción", required=True)

    tarea_id = fields.Many2many('tareas.tarea', string="Tarea")