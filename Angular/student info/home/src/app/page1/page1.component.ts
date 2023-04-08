import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder,Validators } from '@angular/forms';

@Component({
  selector: 'app-page1',
  templateUrl: './page1.component.html',
  styleUrls: ['./page1.component.css']
})
export class page1Component implements OnInit {
  userForm: FormGroup;
  listData: any;
  constructor(private fb:FormBuilder)
  {
    this. listData=[];



    this.userForm=this.fb.group({
      name:['', Validators.required],
      address:['', Validators.required],
      gender:['', Validators.required],
      contactNo:['', Validators.required],
      birthDate:['', Validators.required],
      fees:['',Validators.required],
    })
  }
    public addItem():void{
      this.listData.push(this.userForm.value);
      this.userForm.reset();
      this.calculate(this.listData);
    }


    total=0
    malecount=0
    femalecount=0
    calculate(data: any): void{
      this.total=data.length;
      this.malecount=data.filter((student:{gender: string}) => student.gender === 'male').length;
      this.femalecount=data.filter((student:{gender: string}) => student.gender === 'female').length;

    }
    ngOnInit ():void
    {

    }
  }
