import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Constrains } from '../Classes/Constrains';

@Injectable({
  providedIn: 'root'
})
export class AbsencesService {

  constructor(private client:HttpClient) { }
  
 }
