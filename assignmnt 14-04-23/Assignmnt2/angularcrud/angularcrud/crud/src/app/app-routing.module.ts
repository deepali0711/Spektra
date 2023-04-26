import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { DetailsComponent } from './details/details.component';
import { CreateComponent } from './create/create.component';
import { UpdateComponent } from './update/update.component';

const routes: Routes = [
  {path:'',redirectTo:'home',pathMatch:'full'},
  { path:'crud', redirectTo:'home', pathMatch:'full'},
  {path:'home', component:HomeComponent},
  {path:'details/:productId', component:DetailsComponent},
  {path:'create', component:CreateComponent},
  {path:'update', component:UpdateComponent}  
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
