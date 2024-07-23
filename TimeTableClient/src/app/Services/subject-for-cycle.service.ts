import { JsonPipe } from '@angular/common';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ResultTbl } from '../Classes/Result';
import { IscedualValidate, SubjectForCycle } from '../Classes/SubjectForCycle';

@Injectable({
  providedIn: 'root'
})
export class SubjectForCycleService {

  url:string="https://localhost:5001/api/SubjectForCycle/"

  constructor(private client:HttpClient,
    private customJsonPipe: CustomJsonPipe) { }

    getAllSubjectForCycle():Observable<Array<SubjectForCycle>>
    {
     return this.client.get<Array<SubjectForCycle>>(this.url+"getAllSubjectForCycle")
    }

chekScedualBySubjectAmount(scedualPerGrade: Array<ResultTbl>, cycleId: number): Observable<Array<IscedualValidate>> {
   var headers = {"Content-Type": "application/json"};
  var params = JSON.stringify(scedualPerGrade);
 return this.client.post<Array<IscedualValidate>>(this.url+"chekScedualBySubjectAmount?cycleId="+cycleId, params, {headers: headers});
}


}






export class CustomJsonPipe extends JsonPipe {
  override transform(value: any): string {
    if (value instanceof ResultTbl) {
      return JSON.stringify({
        Id: value.id,
        idTeacher: value.idTeacher, 
        idSubject: value.idSubject, 
       idGrade:value.idGrade, 
       idLesson:value.idLesson, 
      });
    } else {
      return super.transform(value);
    }
  }
}