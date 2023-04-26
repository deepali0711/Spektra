import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { DetailsService } from '../details.service';
@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit{
  actRoute: any;
  ngOnInit(): void {
    
  }
  constructor(
    public fb:FormBuilder,
    private router: Router,
    public detailsService: DetailsService
  ){

  }
  editProducts=this.detailsService.editProduct;

  formEdit = this.fb.group({
    name: this.fb.control(this.editProducts.name),
    details:  this.fb.control(this.editProducts.details),
    price:  this.fb.control(this.editProducts.price),
    type: this.fb.control(this.editProducts.type)
  })

  submitForm(){
    
    this.detailsService.edit(this.editProducts.id,this.formEdit.value).subscribe((data:any) => {
      console.log('product updated')
      this.router.navigate(['home'])
    })
  }
}
