import { Component } from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'joke-list',
  templateUrl: './joke-list.component.html',
})

export class JokeListComponent {
  jokes: Joke[];
  constructor() {
    this.jokes = [
      new Joke("What did the cheese say when it looked in the mirror?", "Hello-me (Halloumi)"),
      new Joke("What kind of cheese do you use to disguise a small horse?", "Mask-apony (Mascarpone)"),
      new Joke("A kid threw a lump of cheddar at me", "I thought ‘That’s not very mature’"),
    ];
  }
  addJoke(joke :Joke) {
    this.jokes.unshift(joke);
  }
}