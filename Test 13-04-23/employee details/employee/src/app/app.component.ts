import { Component,OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
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
  ngOnInit():void{}
  title = 'employee';
}
