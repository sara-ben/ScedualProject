import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Lesson } from '../Classes/Lesson';

@Injectable({
  providedIn: 'root'
})
export class LessonService {
  lessonList: Array<Lesson> =new Array<Lesson>();

  url:string="https://localhost:5001/api/Lesson/"

  constructor(private client:HttpClient) { }

  getAllLessons():Observable<Array<Lesson>>//שליפת כל השפים
  {
   return this.client.get<Array<Lesson>>(this.url+"getAllLessons")
}
}