import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Cart1Component} from './cart1/cart1.component';
import { Cart2Component } from './cart2/cart2.component';
import { Cart3Component } from './cart3/cart3.component';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';


const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'homeLink', component:HomeComponent},
  {path:'cart1Link',component:Cart1Component},
  {path:'cart2Link',component:Cart2Component},
  {path:'cart3Link',component:Cart3Component},
  {path:'homeLink',component:AppComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
