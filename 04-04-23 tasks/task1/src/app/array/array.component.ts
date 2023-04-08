import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-array',
  templateUrl: './array.component.html',
  styleUrls: ['./array.component.css']
})
export class ArrayComponent implements OnInit{
  constructor(){}
  ngOnInit(): void{
    
  }
  users:any[][]=[[1,'deepali','pune'],[2, 'sanchi' , 'yavatmal'],[3,'yash', 'nagpur']];
  validity:string="";
  isValid(valid:string):void{
    this.validity=valid;
  }
  country:string='';
}
  
