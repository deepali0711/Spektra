import { Component,OnInit } from '@angular/core';
import { DetailsService } from './../details.service';
import { items } from '../items';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css'],
  providers:[DetailsService]

})
export class CartComponent implements OnInit {
  cartData!:items[];
  constructor(private cartDetails:DetailsService){
 this.cartData=this.cartDetails.getDetails();
 this.calculateTotal();
  }
  ngOnInit(): void {}
  totalQuantity:number=0;
  totalPrice:number=0;
  calculateTotal(): void {
    let totalQty = 0;
    let totalPrice = 0;
    for (const item of this.cartData) {
      totalQty += item.qty;
      totalPrice += item.price;
    }
    this.totalQuantity = totalQty;
    this.totalPrice = totalPrice;
  }

      

}
