import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './employee/employee.component';
import { InformationComponent } from './information/information.component';
import { DetailsService } from './details.service';
import {  HttpClientModule } from '@angular/common/http';
@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    InformationComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
  ],
  providers: [DetailsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
