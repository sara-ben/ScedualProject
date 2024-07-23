import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Day } from '../Classes/Day';

@Injectable({
  providedIn: 'root'
})
export class DayService {
dayList: Array<Day> =new Array<Day>();
  url:string="https://localhost:5001/api/Day/"
  constructor(private client:HttpClient) { }

  getAllDays():Observable<Array<Day>>
   {
    return this.client.get<Array<Day>>(this.url+"getAllDays")
   }}
