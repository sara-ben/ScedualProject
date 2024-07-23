import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Houer } from '../Classes/Houer';

@Injectable({
  providedIn: 'root'
})
export class HourService {
  houerList: Array<Houer> =new Array<Houer>();

  url:string="https://localhost:5001/api/Hour/"
  constructor(private client:HttpClient) { }

  getAllHouer():Observable<Array<Houer>>//שליפת כל השפים
   {
    return this.client.get<Array<Houer>>(this.url+"getAllHoures")
   }}
 