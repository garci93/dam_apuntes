import { Component, OnInit } from '@angular/core';
import { PrincipalService } from '../servicios/ServicioPrincipal/principal.service';

@Component({
  selector: 'app-principal',
  templateUrl: './principal.component.html',
  styleUrls: ['./principal.component.css']
})
export class PrincipalComponent implements OnInit{

  listaPreguntas: any[] = [];
  pregunta!: any;
  respuestas: any[] = [];

  numPregunta:number = 0;
  numPreguntasAcertadas: number = 0;
  numPreguntasFalladas: number = 0;
  juegoCompletado: boolean = false;

  constructor(private principalService: PrincipalService) {}

  async ngOnInit(): Promise<void> {
    try {
      const data = await this.principalService.getTriviaData().toPromise();
      this.listaPreguntas = data.results;

      this.pregunta = this.listaPreguntas[this.numPregunta];
      this.respuestas = [
        this.pregunta.incorrect_answers[0],
        this.pregunta.incorrect_answers[1],
        this.pregunta.incorrect_answers[2],
        this.pregunta.correct_answer
      ];
      this.respuestas.sort(() => Math.random() - 0.5)
    } catch (error) {
      console.error('Error al obtener datos de trivia:', error);
    }
  }

  cargarPregunta(){
    if (this.numPregunta < this.listaPreguntas.length) {
      this.pregunta = this.listaPreguntas[this.numPregunta];
      this.respuestas = [
        this.pregunta.incorrect_answers[0],
        this.pregunta.incorrect_answers[1],
        this.pregunta.incorrect_answers[2],
        this.pregunta.correct_answer
      ];
      this.respuestas.sort(() => Math.random() - 0.5)
    } else {
      this.juegoCompletado = true;
    }
  }

  respuestaSeleccionada(respuesta: string){
    if(respuesta == this.pregunta.correct_answer){
      this.numPreguntasAcertadas++;
    }
    else{
      this.numPreguntasFalladas++;
    }
    this.numPregunta++;
    this.cargarPregunta();
  }


}
