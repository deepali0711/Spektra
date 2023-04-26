import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Person1Component } from './person1/person1.component';
import { Person2Component } from './person1/person2/person2.component';
import { Person3Component } from './person3/person3.component';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  constructor(private router:Router){}
  Getperson1()
  {
    this.router.navigate(['person1'])
  }
  Getperson2()
  {
    this.router.navigate(['person2'])
  }
  Getperson3()
  {
    this.router.navigate(['person3'])
  }
  ngOnInit(): void {
  }
  
  title = 'employee';
}
