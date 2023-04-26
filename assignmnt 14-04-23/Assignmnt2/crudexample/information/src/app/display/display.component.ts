import { Component } from '@angular/core';
import { DetailsService } from '../details.service';
import { details } from '../information';
import { Router } from '@angular/router';

@Component({
  selector: 'app-display',
  templateUrl: './display.component.html',
  styleUrls: ['./display.component.css']
})
export class DisplayComponent {
  products: details [] = [];
  

  constructor (public detailsService:DetailsService, private router:Router) { }

  ngOnInit() {

    this.detailsService.getData().subscribe((data:details[]) => {
    console.log(data);
    this.products = data;  
    })
  }

  delete(id:any){
   this.detailsService.delete(id).subscribe(() => {
     
    },(err: any)=>console.error(err),
    () => console.log("Error") );
    this.detailsService.getData().subscribe((data:details[]) => {
      console.log(data);
      this.products = data;  
      })
    
  }
  createPr(){
    this.router.navigate(['add'])
  }
  edit(product:any){
    this.detailsService.editProduct=product;
    this.router.navigate(['edit'])
  }

}
