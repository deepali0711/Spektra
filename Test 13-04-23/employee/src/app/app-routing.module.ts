import {  NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Person1Component } from './person1/person1.component';
import { Person2Component } from './person1/person2/person2.component';
import { Person3Component } from './person3/person3.component';
const routes: Routes = [
  {path:"person1",component:Person1Component},
  {path:"person2",component:Person2Component},
  {path:"person3",component:Person3Component},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
