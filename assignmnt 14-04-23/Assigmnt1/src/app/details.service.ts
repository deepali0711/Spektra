import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IDetails } from './employee';
import { Observable } from 'rxjs';
@Injectable()
export class DetailsService {
  private_url="http://localhost:3000/employees";


  constructor(private http: HttpClient){}
  getEmployees():Observable<IDetails[]>{
    return this.http.get<IDetails[]>(this.private_url);
  }
}

