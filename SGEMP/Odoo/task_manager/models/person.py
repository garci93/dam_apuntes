from odoo import models, fields, api

class Person(models.Model):
    _name = 'task_manager.person'
    _description = 'Personas del módulo'
    
    name = fields.Char(string="Nombre", required=True)
    age = fields.Integer(string="Edad")
    role = fields.Selection([('manager', 'Jefe'), ('employee', 'Empleado')], string="Rol")
    assigned_tasks_count = fields.Integer(compute='_compute_total', store=True)
    tasks_ids = fields.Many2many('tasks.task')

    @api.depends("tasks_ids")
    def _compute_total(self):
        for record in self:
            record.assigned_tasks_count = len(record.tasks_ids) if record.tasks_ids else 0

    def delete_person(self):
        self.ensure_one()
        self.unlink()
        return {
            'type': 'ir.actions.act_window',
            'res_model': 'tasks.person',
            'view_mode': 'tree,form',
            }