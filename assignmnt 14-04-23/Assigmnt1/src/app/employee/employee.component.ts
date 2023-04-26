import { Component, OnInit } from '@angular/core';
import { DetailsService } from '../details.service';
import { IDetails } from '../employee';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  
  employeeData!:IDetails[];
   constructor(private detailsService:DetailsService) {}

   ngOnInit() {
        this.detailsService.getEmployees()
        .subscribe((data) =>{
          this.employeeData = data
        } )
   }
   }

 
