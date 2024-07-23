import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TeacherLessonsService {
  url:string="https://localhost:5001/api/Lesson/"
  constructor(private client:HttpClient) { }

  
}
