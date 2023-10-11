import { Component, Input } from '@angular/core';
import {Output, EventEmitter} from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'joke-form',
  templateUrl: './joke-form.component.html',
})
export class JokeFormComponent {

  @Output() jokeCreated = new EventEmitter<Joke>();

  createJoke(setup: string, punchline: string) {
    this.jokeCreated.emit(new Joke(setup, punchline));
  }
}
