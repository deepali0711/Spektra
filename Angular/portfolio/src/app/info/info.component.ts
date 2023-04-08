import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  styleUrls: ['./info.component.css']
})
export class InfoComponent implements OnInit{
  Details:any;
  constructor(private router: ActivatedRoute){

  }
  ngOnInit(): void {
    let id: any=this.router.snapshot.paramMap.get('id');
    this.Details=id;
    
  }
  personsList=[

    {"id":"1","Name":"sanchi","technology":"Front End","image":"portfolio\src\assets\person_1.jpeg"},
    
    {"id":"2","Name":"Deepali","technology":"Back End","image":"portfolio\src\assets\person_2.jpeg"},
    
    {"id":"3","Name":"Yash","technology":"Cyber Security","image":"portfolio\src\assets\person_3.jpeg"},
    
    {"id":"4","Name":"Himanshu","technology":"UI/UX Designer","image":"portfolio\src\assets\person_4.jpeg"}
    
    ]

}
