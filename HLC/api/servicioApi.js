
const axios = require('axios');

class ServicioApi{

    async getApiPreguntasPeliculasData(){
        try{
            const response = await axios.get('https://opentdb.com/api.php?amount=10&category=11&type=multiple')
            return response.data;
        }
        catch(error){
            throw new Error('Error al obtener datos de la API externa');
        }
    }

    async getApiPreguntasDeportesData(){
        try{
            const response = await axios.get('https://opentdb.com/api.php?amount=10&category=21&type=multiple')
            return response.data;
        }
        catch(error){
            throw new Error('Error al obtener datos de la API externa');
        }
    }

}

module.exports = new ServicioApi();