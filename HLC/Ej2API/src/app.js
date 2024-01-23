const express = require('express');

const Service = require('./service');

const app = express();
const port = 3000;

let service = new Service();

app.use(express.json());

app.listen(port, () => {
    console.log(`Servicio abierto en el puerto ${port}`);
});

app.post("/crearcontacto", async (req, res) => {
    const contacto = req.body;
    res.json(await service.crearContacto(contacto));
});

app.get("/buscarcontacto/:id", async(req, res) => {
    const id = req.params.id
    res.json(await service.buscarContacto(id));
});

app.put("/actualizacontacto/:id", async (req, res) =>{

    const id = req.params.id;
    const contacto = req.body;
    res.json(await service.actualizaContacto(id, contacto));
});

app.delete('/borracontacto/:id', async (req, res) => {
    const id = req.params.id;
    res.json(await service.borraContacto(id));
});