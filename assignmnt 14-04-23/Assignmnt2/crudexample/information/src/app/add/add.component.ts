import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { DetailsService } from '../details.service';
@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit{
  userForm: any=[];
  Productarr: any = [];

  
 
  ngOnInit(): void {
    this.userForm = this.fb.group({
      name: [' '],
      type: [''],
      details:[''],
      price:[''],
    })
  }
  constructor(
    public fb:FormBuilder,
    private router: Router,
    public detailsService: DetailsService
  ) {}

  submitForm() {
    this.detailsService.add(this.userForm.value).subscribe((res: any) => {
      alert("Product added Successfully.......")
      this.router.navigate(['home'])
    })
  }

}
