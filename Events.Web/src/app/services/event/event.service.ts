import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class EventService {

  apiUrl: string;

  constructor(private http: HttpClient) {
    this.apiUrl = 'http://localhost:4000/api/events/';
   }

  getAllEvents(): Observable<any> {
   return this.http.get(this.apiUrl + 'getall');
  }

  getById(id: string): Observable<any> {
    return this.http.get(this.apiUrl + 'getevent/' + id);
   }
}
