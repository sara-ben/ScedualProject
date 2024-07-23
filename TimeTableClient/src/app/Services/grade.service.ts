import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Grade } from '../Classes/Grade';

@Injectable({
  providedIn: 'root'
})
export class GradeService {
  gradeList: Array<Grade> =new Array<Grade>();
  selectedGrade: Grade | undefined;

  url:string="https://localhost:5001/api/Grade/"
  constructor(private client:HttpClient) { }

  getAllGrade():Observable<Array<Grade>>//שליפת כל השפים
   {
    return this.client.get<Array<Grade>>(this.url+"getAllGrades")
   }
}
