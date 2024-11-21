import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProfessorService {
  private apiUrl = 'https://localhost:7266/api/professor'; // URL do backend

  constructor(private http: HttpClient) { }

  getProfessores(): Observable<string[]> {
    return this.http.get<string[]>(this.apiUrl); // Faz a requisição HTTP
  }
}
