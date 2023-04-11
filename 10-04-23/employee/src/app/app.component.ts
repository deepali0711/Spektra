import { Component } from '@angular/core';
import { DataService } from './services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'employee';
  memberData=[
    {name:'harshavardhan', city:'banglore'},
    {name:'shiva', city:'banglore'},
    {name:'chinto', city:'banglore'},
    {name:'ayush', city:'banglore'},
  ]
  constructor(private user: DataService)
  {
    console.warn("user",user.users())
    this.memberData=user.users();
  }
}
