const express = require('express');
const cors = require('cors'); //Soluciona este error: principal:1 Access to XMLHttpRequest at 'http://localhost:3000/principal' from origin 'http://localhost:4200' has been blocked by CORS policy: No 'Access-Control-Allow-Origin' header is present on the requested resource.
const servicioApi = require('./servicioApi');

const app = express();
const servicio = servicioApi;

app.use(cors());

app.get('/principal', async (req, res) => {
    try {
        const triviaData = await servicio.getApiData();
        res.json(triviaData);
    } catch (error) {
        console.error(error);
        res.status(500).send('Error al obtener datos de la API externa de trivia');
    }
});

app.listen(3000, () => {
    console.log('Server is up on port 3000.')
});
