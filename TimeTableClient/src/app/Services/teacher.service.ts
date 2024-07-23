import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Teacher } from '../Classes/Teacher';

@Injectable({
  providedIn: 'root'
})
export class TeacherService {
  url:string="https://localhost:5001/api/Teacher/"
  teacherList: Array<Teacher> =new Array<Teacher>();
  constructor(private client:HttpClient) { }

  getAllTeacher():Observable<Array<Teacher>>//שליפת כל השפים
  {
   return this.client.get<Array<Teacher>>(this.url+"getAllTeacher")
  }


}
