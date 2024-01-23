const {MongoClient, ObjectId} = require('mongodb');

class Service{

    constructor(){
        this.db;
        this.connect();
    }

    async connect(){
        const connectionURL = 'mongodb://127.0.0.1:27017';
        const databaseName = 'GestionarContactos';
        
        try{
            let client = await MongoClient.connect(connectionURL);
            this.db = client.db(databaseName);
        }
        catch(error){
            console.log(error);
        }
    }

    async crearContacto(contacto){
        try{
            return await this.db.collection("contacto").insertOne(contacto);
        }
        catch(error){
            return {error: "Error. No se pudo crear el contacto"};
        }
    }

    async buscarContacto(id){
        try{
            return await this.db.collection("contacto").findOne({_id: new ObjectId(id)});
        }
        catch(error){
            return {error: "Error. No se pudo buscar el contacto"};
        }
    }

    async actualizaContacto(id, contacto){
        try{
            return await this.db.collection("contacto").findOneAndUpdate({_id: new ObjectId(id)}, {$set: contacto}, {returnDocument: "after"});
        }
        catch(error){
            return {error: "Error. No se pudo actualizar el contacto"};;
        }
    }

    async borraContacto(id){
        try{
            return await this.db.collection("contacto").deleteOne({_id: new ObjectId(id)});
        }
        catch(error){
            return {error: "Error. No se pudo borrar el contacto"};;
        }
    }
}

module.exports = Service;