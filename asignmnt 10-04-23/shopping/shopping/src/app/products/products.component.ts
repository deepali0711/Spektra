import { Component, OnInit } from '@angular/core';
import { DetailsService } from './../details.service';
import { items } from '../items';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
  export class ProductsComponent implements OnInit{

    productDetails!:items[];
    constructor(private productsData:DetailsService){
      this.productDetails=productsData.getDetails();
    }
    ngOnInit(): void {
      throw new Error('Method not implemented.');
    }
    

}
