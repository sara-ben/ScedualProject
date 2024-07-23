import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ResultTbl } from '../Classes/Result';

@Injectable({
  providedIn: 'root'
})
export class ResultService {
  resultList: Array<ResultTbl> =new Array<ResultTbl>();

  url:string="https://localhost:5001/api/Result/"

  constructor(private client:HttpClient) { }
  getAllResult():Observable<Array<ResultTbl>>//שליפת כל השפים
   {
    return this.client.get<Array<ResultTbl>>(this.url+"getAllResult")
}

chekAllResults(allResults: Array<ResultTbl>):Observable<Array<any>>{
  var headers = {"Content-Type": "application/json"};
  var params = JSON.stringify(allResults);
  return this.client.post<Array<ResultTbl>>(this.url+"chekAllResults" ,params, {headers: headers} )
}
editSchedual(allResults: Array<ResultTbl>){
  return this.client.put<Array<ResultTbl>>(this.url+"editSchedual", allResults )
}


}