from odoo import models, fields, api

class Task(models.Model):
    _name = 'task_manager.task'
    _description = 'Tareas del módulo'
    
    name = fields.Char(string="Nombre", required=True)
    description = fields.Text(string="Descripción")
    creation_date = fields.Datetime('Fecha de creación', default=lambda self: fields.Datetime.now())
    end_date = fields.Datetime('End date')
    assigned_people_count = fields.Integer(compute='_compute_total', store=True)
    state = fields.Selection([('draft', 'Asignada'), ('progress', 'En proceso'), ('done', 'Completada')],
                             string='Estado', default='draft', required=True)
    people_ids = fields.Many2many('tasks.person')

    @api.depends("people_ids")
    def _compute_total(self):
        for record in self:
            record.assigned_people_count = len(record.people_ids) if record.people_ids else 0