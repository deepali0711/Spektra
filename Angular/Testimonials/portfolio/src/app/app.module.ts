import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { Person1Component } from './person1/person1.component';
import { Person2Component } from './person2/person2.component';
import { Person3Component } from './person3/person3.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    Person1Component,
    Person2Component,
    Person3Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
