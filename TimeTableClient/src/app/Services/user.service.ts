import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { user } from '../Classes/User';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  url: string = "https://localhost:5001/api/Users/"
  constructor(private client: HttpClient) { }
  login() {

  }
  getAllUsers(): Observable<Array<user>> {
    return this.client.get<Array<user>>(this.url + "GetAllUsers");

  }

  registerUser(user: any): Observable<user> {
    return this.client.post<user>(this.url + 'AddUser', user);
  }

}

