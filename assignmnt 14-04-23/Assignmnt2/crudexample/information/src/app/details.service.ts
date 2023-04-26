import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { details } from './information';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DetailsService {
  
  
  httpOptions = {
    headers: new HttpHeaders ({
      'Content-Type':'application/json'
    })
  }
  editProduct!:details;
  api="http://localhost:3000/info"
  constructor(private httpClient:HttpClient) { }

  add(product: any): any {
    return this.httpClient.post<details> (this.api, JSON.stringify(product),this.httpOptions)
  }


  getData(): any{
    return this.httpClient.get<details[]>(this.api+'/')
  }

  edit(id: number, product: any): any {
    return this.httpClient.put<details>(this.api+'/' + id, JSON.stringify(product),this.httpOptions)
  }

  delete(id: number){
    return this.httpClient.delete<details>(this.api + '/' + id)
  }

}

