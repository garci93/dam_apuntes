import { Component } from '@angular/core';
import {Output, EventEmitter} from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'joke-form',
  template: `
  <div class="card card-block">
    <h4 class="card-title">Create Joke</h4>
    <div class="form-group">
    <input type="text"
      class="form-control"
      placeholder="Enter the setup">
    </div>
    <div class="form-group">
    <input type="text"
      class="form-control"
      placeholder="Enter the punchline"> 
    </div>
    <button type="submit"
      class="btn btn-primary">Create
    </button>
  </div>
  `
})
export class JokeFormComponent {
  @Output() jokeCreated = new EventEmitter<Joke>();

  createJoke(setup: string, punchline: string) {
    this.jokeCreated.emit(new Joke(setup, punchline));
  }
}
