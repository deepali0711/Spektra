import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Cart1Component } from './cart1/cart1.component';
import { Cart2Component } from './cart2/cart2.component';
import { Cart3Component } from './cart3/cart3.component';
import { HomeComponent } from './home/home.component';
import { InfoComponent } from './info/info.component';


@NgModule({
  declarations: [
    AppComponent,
    Cart1Component,
    Cart2Component,
    Cart3Component,
    HomeComponent,
    InfoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
