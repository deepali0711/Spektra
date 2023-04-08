import { NgFor  } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  constructor(private router: Router){}
  ngOnInit(): void { }
  personsList=[

    {"id":"1","Name":"sanchi","technology":"Front End","image":"portfolio\src\assets\person_1.jpeg"},
    
    {"id":"2","Name":"Deepali","technology":"Back End","image":"portfolio\src\assets\person_2.jpeg"},
    
    {"id":"3","Name":"Yash","technology":"Cyber Security","image":"portfolio\src\assets\person_3.jpeg"},
    
    {"id":"4","Name":"Himanshu","technology":"UI/UX Designer","image":"portfolio\src\assets\person_4.jpeg"}
    
    ]
    
    display(person:any){
    
    console.log(person.id);
    
    this.router.navigate(['/persons',person])
    }
}
