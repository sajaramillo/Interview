import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class StudentsService {

  constructor(private httpClient:HttpClient) { }

  async getAll(){
    const uri = environment.API + '/students'
   return  this.httpClient.get(uri).toPromise();
  }
}
