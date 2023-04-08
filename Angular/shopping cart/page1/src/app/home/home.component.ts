import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  constructor(private router:Router){
    
  }
  getUser1(){
    this.router.navigate(['cart1Link'])
  }
  getUser2(){
    this.router.navigate(['cart2Link'])
  }
  getUser3(){
    this.router.navigate(['cart3Link'])
  }
  ngOnInit(): void {
    
  }
  title = 'Shopperz Point';
  Users=[{"Ladies_bag":"bag1"},
  {"Hand_bag":"bag2"},
  {"Sling_bag":"bag3"}
]

}
  


