import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Person1Component } from './person1/person1.component';
import { Person2Component } from './person1/person2/person2.component';
import { Person3Component } from './person3/person3.component';

@NgModule({
  declarations: [
    AppComponent,
    Person1Component,
    Person2Component,
    Person3Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    Person1Component,
    Person2Component,
    Person3Component,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
