import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DisplayComponent } from './display/display.component';
import { EditComponent } from './edit/edit.component';
import { AddComponent } from './add/add.component';

const routes: Routes = [
  {path:'',redirectTo:'add',pathMatch:'full'},
  {path:'home', component:DisplayComponent},
  {path:'add', component:AddComponent},
  {path:'edit', component:EditComponent}  
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
