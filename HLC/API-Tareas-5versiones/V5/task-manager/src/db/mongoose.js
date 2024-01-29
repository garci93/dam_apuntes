const mongoose = require('mongoose')

mongoose.connect('Aquí hay que poner la URL a la BD', {
    useNewUrlParser: true,
    useCreateIndex: true,
    useFindAndModify: false
})