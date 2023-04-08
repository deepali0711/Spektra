import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-helloapp',
  templateUrl: './helloapp.component.html',
  styleUrls: ['./helloapp.component.css']
})
export class HelloappComponent implements OnInit 
{
title: string =' Welcome to spektra';

constructor(){}
ngOnInit(): void {
  
}
}
