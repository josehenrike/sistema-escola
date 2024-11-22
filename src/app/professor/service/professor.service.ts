import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProfessorService {

  private apiUrl = 'https://localhost:7266/api/professor';

  constructor(private http: HttpClient) { }

  getProfessores(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
