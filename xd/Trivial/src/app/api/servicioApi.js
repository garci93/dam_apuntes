
const axios = require('axios');

class ServicioApi{

    async getApiData(){
        try{
            const response = await axios.get('https://opentdb.com/api.php?amount=5&category=18&type=multiple')
            return response.data;
        }
        catch(error){
            throw new Error('Error al obtener datos de la API externa');
        }
    }

}

module.exports = new ServicioApi();