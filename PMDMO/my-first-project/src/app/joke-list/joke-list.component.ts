import { Component } from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'joke-list',
  templateUrl: './joke-list.component.html',
})

export class JokeListComponent {
  jokes: Joke[];
  constructor() {
    this.jokes = [];
  }
  addJoke(joke :Joke) {
    this.jokes.unshift(joke);
  }
  deleteJoke(joke :Joke) {
    // var encontrado = false,i;
    for (var i=0; i < this.jokes.length; i++) {
      if (this.jokes[i] == joke)
        this.jokes = this.jokes.filter(j => j != joke);
    }
  }
}