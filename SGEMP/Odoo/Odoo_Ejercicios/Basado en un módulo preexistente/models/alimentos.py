# models/alimentos.py
from odoo import models, fields

class Alimento(models.Model):
    _inherit = 'product.template'

    calorias = fields.Float(string='Calorías')
