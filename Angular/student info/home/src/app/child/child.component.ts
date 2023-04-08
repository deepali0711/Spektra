import { Component, OnInit,Input } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {

  @Input() hero: any;
  @Input() total: any;
  @Input() countmale: any;
  @Input() countfemale: any;

  constructor() {}

 ngOnInit(): void {
   
 }
}
