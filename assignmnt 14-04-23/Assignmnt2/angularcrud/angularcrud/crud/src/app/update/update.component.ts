import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup} from '@angular/forms';
import { CrudService } from '../crud.service';
import { Router, ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

 
  actRoute: any;
  
  
  ngOnInit(): void {
    
  }
  constructor(
    public fb:FormBuilder,
    private router: Router,
    public crudService: CrudService
  ) {
    
    // var id = this.actRoute.snapshot.paramMap.get('id');
    // this.crudService.getById(this.id).subscribe((res) => {
    //   this.updateproductform = this.fb.group({
    //     id:[res.id],
    //     name:[res.name],
    //     description:[res.description],
    //     price:[res.price],
    //     quantity:[res.quantity]
    //   })
    // })

    // }
  }
    editProduct=this.crudService.editProduct;

    updateproductform = this.fb.group({
    name: this.fb.control(this.editProduct.name),
    description:  this.fb.control(this.editProduct.description),
    price:  this.fb.control(this.editProduct.price),
    quantity: this.fb.control(this.editProduct.quantity)
  })

  // updateform(){
  //   this.updateproductform = this.fb.group({
  //     name:[''],
  //     description:[''],
  //     price:[''],
  //     quantity:['']
  //   })
  // }

  submitForm(){
    
    this.crudService.update(this.editProduct.id,this.updateproductform.value).subscribe(res => {
      console.log('product updated')
      this.router.navigate(['home'])
    })
  }
  
}
