import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SalaService {
  private apiUrl = 'https://localhost:7266/api/sala';

  constructor(private http: HttpClient) { }

  getSalas(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
