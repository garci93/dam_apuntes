import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { JokeListComponent } from './joke-list/joke-list.component';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

@NgModule({
  imports: [BrowserModule],
  declarations: [JokeListComponent],
  bootstrap: [JokeListComponent]
})
export class AppModule {
}

