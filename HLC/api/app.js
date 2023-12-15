const express = require('express');
const cors = require('cors');
const ServicioApi = require('./servicioApi');
const app = express();
const port = 3000;

app.use(cors());

app.listen(port, () => {
    console.log(`Escuchando en el puerto ${port}`);
});

app.get('/api/preguntas-peliculas', async (req, res) => {
    try {
        const response = await ServicioApi.getApiPreguntasPeliculasData();
        res.send(response);
    } catch (error) {
        console.error("Error en la petición en el lado del servidor: \n", error);
    }
});

app.get('/api/preguntas-deportes', async (req, res) => {
    try {
        const response = await ServicioApi.getApiPreguntasDeportesData();
        res.json(response);
    } catch (error) {
        res.status(500).send(error.message);
    }
});