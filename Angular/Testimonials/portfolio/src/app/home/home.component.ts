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
    this.router.navigate(['person1Link'])
  }
  getUser2(){
    this.router.navigate(['person2Link'])
  }
  getUser3(){
    this.router.navigate(['person3Link'])
  }
  ngOnInit(): void {
    
  }
  title = 'portfolio';
  Users=[
    {"Srno":"1","Developer":"JAN STROJEWSKI","Technology":"Full Stack "},
    {"Srno":"2","Developer":"MICHAL PANEK","Technology":"Frontend"},
    {"Srno":"3","Developer":"THOMAS VAN","Technology":"Backend"}
    ]

}
