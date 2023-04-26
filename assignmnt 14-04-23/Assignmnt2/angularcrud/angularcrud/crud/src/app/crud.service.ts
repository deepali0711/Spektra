import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from './product';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CrudService {

  private apiServer = "http://localhost:3000";

  httpOptions = {
    headers: new HttpHeaders ({
      'Content-Type':'application/json'
    })
  }

  editProduct:any;
  constructor(private httpClient:HttpClient) { }

  create(product: any): Observable<Product> {
    return this.httpClient.post<Product> (this.apiServer + '/Product/', JSON.stringify(product),this.httpOptions)
  }

  getById(id: string): Observable<Product> {
    return this.httpClient.get<Product>(this.apiServer + '/Product/' + id)
  }

  getAll(): Observable<Product[]> {
    return this.httpClient.get<Product[]>(this.apiServer + '/Product/')
  }

  update(id: number, product: any): Observable<Product> {
    return this.httpClient.put<Product>(this.apiServer + '/Product/' + id, JSON.stringify(product), this.httpOptions)
  }

  delete(id: number){
    return this.httpClient.delete<Product>(this.apiServer + '/Product/' + id, this.httpOptions)
  }

}
