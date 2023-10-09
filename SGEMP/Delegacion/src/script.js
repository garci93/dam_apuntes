//Selecciono la tabla para luego cambiar sus estilos.
let miTabla = document.querySelector('table');

//Hago un bucle para recorrer los objetos del array (celdas)

miTabla.addEventListener('click', (e) => {e.target.classList.add('celdaPulsado')})