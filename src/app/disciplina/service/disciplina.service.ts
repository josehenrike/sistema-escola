import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DisciplinaService {

  private apiUrl = 'https://localhost:7266/api/Disciplina';

  constructor(private http: HttpClient) { }

  // Método para buscar as disciplinas
  getDisciplinas(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
