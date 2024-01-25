# -*- coding: utf-8 -*-
{
    'name': "tareas",
    'summary': "Módulo para gestionar tareas",
    'description': "Este módulo posee dos vistas (de árbol y de formulario) asociadas y un menú que permite acceder a estas dos vistas.",
    'author': "José Joaquín Garci Peña",
    'category': 'Uncategorized',
    'version': '1.0',
    'depends': ['base'],

    # always loaded
    'data': [
        # 'security/ir.model.access.csv',
        'views/views.xml',
    ],
    # only loaded in demonstration mode
    'demo': [
        'demo/demo.xml',
    ],
    'installable' : True,
    'application': True
}