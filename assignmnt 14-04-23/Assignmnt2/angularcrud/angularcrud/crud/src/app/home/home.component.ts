import { Component, OnInit } from '@angular/core';
import { CrudService } from '../crud.service';
import { Product } from '../product';
import { Router } from '@angular/router';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  products: Product [] = [];

  constructor (public crudService:CrudService, private router:Router) { }

  ngOnInit() {

    this.crudService.getAll().subscribe((data:Product[]) => {
    console.log(data);
    this.products = data;  
    })
  }

  delete(id:any){
   this.crudService.delete(id).subscribe(res => {
     
    },err=>console.error(err),
    () => console.log("Error") );
    this.crudService.getAll().subscribe((data:Product[]) => {
      console.log(data);
      this.products = data;  
      })
    
  }
  createPr(){
    this.router.navigate(['create'])
  }
  edit(product:any){
    this.crudService.editProduct=product;
    this.router.navigate(['update'])
  }

}
