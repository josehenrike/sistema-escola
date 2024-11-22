import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class TurmaService {
  private apiUrl = 'https://localhost:7266/api/turma';

  constructor(private http: HttpClient) { }

  getTurmas(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
