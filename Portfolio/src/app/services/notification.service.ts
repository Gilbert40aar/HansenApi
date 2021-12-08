import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {

  baseUrl = "https://localhost:44376/api/";

  constructor(private http: HttpClient) { }

  /*getNotificationCount(): Observable<NotificationCountResult> {

  }*/
}
