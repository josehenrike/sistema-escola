import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Professor } from '../professor.model';

@Injectable({
  providedIn: 'root'
})
export class ProfessorService {

  private apiUrl = 'https://localhost:7266/api/professor';

  constructor(private http: HttpClient) { }

  adicionarProfessor(professor: Professor): Observable<Professor> {
    return this.http.post<Professor>(this.apiUrl, professor);
  }

  getProfessores(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }

}
