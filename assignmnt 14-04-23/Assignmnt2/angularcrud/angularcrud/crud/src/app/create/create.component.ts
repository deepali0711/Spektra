import { Component, OnInit} from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { CrudService } from '../crud.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  productform! : FormGroup;
  Productarr: any = [];

  ngOnInit(): void {
    this.productform = this.fb.group({
      name: [' '],
      description: [''],
      price:[''],
      quantity:[''],
    })
  }

  constructor(
    public fb:FormBuilder,
    private router: Router,
    public crudService: CrudService
  ) {}

  

  submitForm() {
    this.crudService.create(this.productform.value).subscribe(res => {
      console.log('Product created!')
      this.router.navigate(['home'])
    })
  }
}
