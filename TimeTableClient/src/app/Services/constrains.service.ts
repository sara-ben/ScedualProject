import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Constrains } from '../Classes/Constrains';

@Injectable({
  providedIn: 'root'
})
export class ConstrainsService {
  url:string="https://localhost:5001/api/Constrains/"
  constructor(private client:HttpClient) { }

  getAllallConstrains():Observable<Array<Constrains>>
  {
   return this.client.get<Array<Constrains>>(this.url+"getAllConstrains")
  }
}
