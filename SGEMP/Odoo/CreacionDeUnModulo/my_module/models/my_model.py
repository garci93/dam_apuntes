# -*- coding: utf-8 -*-
from odoo import models, fields

class MyModel(models.Model):
    _name = 'my.module.model'
    _description = 'My Model'

    name = fields.Char(string='Name', required=True)
    _description = fields.Text(string='Description')