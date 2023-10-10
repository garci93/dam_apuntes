import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { JokeListComponent } from './joke-list/joke-list.component';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { JokeFormComponent } from './joke-form/joke-form.component';
import { JokeComponent } from './joke/joke.component';
import { AppComponent } from './app.component';

@NgModule({
  imports: [BrowserModule],
  declarations: [AppComponent, JokeListComponent, JokeFormComponent, JokeComponent],
  bootstrap: [AppComponent]
})
export class AppModule {
}

platformBrowserDynamic().bootstrapModule(AppModule);


