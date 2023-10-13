import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'joke',
  templateUrl: `./joke.component.html`
})

export class JokeComponent {
  @Input('joke') joke!: Joke;
  @Output() removeJoke = new EventEmitter<any>()

  deleteJoke(){
    this.removeJoke.emit(this.joke);
  }
}