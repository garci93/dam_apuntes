# __manifest__.py

{
    'name': 'Mi Módulo de Alimentos',
    'version': '1.0',
    'author': 'Tu Nombre',
    'depends': ['base', 'product'],  # Dependencias del módulo
    'data': [
        'views/alimentos_views.xml',  # Archivo de vistas
    ],
    'installable': True,
    'auto_install': False,
}