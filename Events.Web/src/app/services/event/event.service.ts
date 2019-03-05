import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class EventService {

  apiUrl: string;
  test: any;

  constructor(private http: HttpClient) {
    this.apiUrl = 'http://localhost:4000/api/events/';
   }

  getAllEvents(): any {
   return this.http.get(this.apiUrl + 'getall');
  }
}
