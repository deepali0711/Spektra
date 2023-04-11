import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DetailsService {
  details1=[
{FirstName:'dipali',city:'pune',age:24,country:'India'},
{FirstName:'dipali',city:'pune',age:24,country:'India'},
{FirstName:'dipali',city:'pune',age:24,country:'India'},
  ]

   getdetails1():any[]{
    return this.details1
   }


  constructor() { }
}
