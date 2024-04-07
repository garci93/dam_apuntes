import { Material } from "./material";

export class Service {
    private materiales: Material[] = [
        new Material('Bolígrafos', 100),
        new Material('Pegatinas', 50),
        new Material('Gomas de borrar', 80),
        new Material('Lápices', 150),
        new Material('Folios', 500)
    ];

    getMateriales(): Material[] {
        return this.materiales;
    }

    agregarMaterial(material: Material) {
        this.materiales = [material].concat(this.materiales.slice());
        console.log(this.materiales);                                       // se actualiza en el console log pero no en la vista???
    }

    quitarMaterial(material: Material) {
        let indiceABorrar = this.materiales.indexOf(material);
        if (indiceABorrar !== -1) {
            this.materiales.splice(indiceABorrar, 1);
        }
    }
}
