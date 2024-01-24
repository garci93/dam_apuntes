# models/persona.py
from odoo import models, fields

class Persona(models.Model):
    _name = 'mi_modulo.persona'
    _description = 'Modelo de Persona'

    name = fields.Char(string='Nombre', required=True)
    age = fields.Integer(string='Edad')
    tasks_ids = fields.One2many('mi_modulo.tarea', 'assigned_to', string='Tareas Asignadas')

    @api.model
    def create(self, values):
        # Llama a la función create del modelo base
        persona = super(Persona, self).create(values)

        # Agrega lógica personalizada aquí
        print(f'Nueva persona creada: {persona.name}')

        return persona
