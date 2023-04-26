import { Injectable } from '@angular/core';
import { items } from './items';

@Injectable({
  providedIn: 'root'
})
export class DetailsService {
  productDetails!:items[];
  getDetails():items[]{
    
    this.productDetails=[
    {itemName:"Shirt",type:"Men's Wear",price:50,qty:1},
    {itemName:" Bag",type:"Bags",price:200,qty:1},
    {itemName:" geans",type:"Men's Wear",price:70,qty:1},
    {itemName:"necklace",type:"ladies jwellery",price:250,qty:1},
    {itemName:" Shirt",type:"Men's Wear",price:80,qty:1},

  ]

  return this.productDetails
}

  constructor() { }
}
