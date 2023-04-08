import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Person1Component } from './person1/person1.component';
import { Person2Component } from './person2/person2.component';
import { Person3Component } from './person3/person3.component';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'homeLink',component:HomeComponent},
  {path:'person1Link',component:Person1Component},
  {path:'person2Link',component:Person2Component},
  {path:'person3Link',component:Person3Component},
  {path:'homeLink',component:AppComponent}
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
