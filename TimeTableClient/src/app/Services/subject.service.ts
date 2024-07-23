import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Subject } from '../Classes/Subject';

@Injectable({
  providedIn: 'root'
})
export class SubjectService {
  url:string="https://localhost:5001/api/Subject/"

  constructor(private client:HttpClient) { }

  getAllSubject():Observable<Array<Subject>>
  {
   return this.client.get<Array<Subject>>(this.url+"getAllSubjects")
  }
}
