import { Component,OnInit } from '@angular/core';
import { DetailsService  } from '../details.service';
@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css'],
  providers:[DetailsService]
})
export class DetailsComponent {
  detailsuser1!:any[]

 
  constructor(private dservice: DetailsService){
    this.detailsuser1=this.dservice.getdetails1();

  }
  display=false;
  show(){
    this.display=!this.display;
  }
  ngOnInit(): void{

  }

}
