import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

// Definindo a interface Professor
interface Professor {
  id: number;
  nome: string;
  disciplina: string;
  sala: string;
  turma: string;
  status: number;  // 0 para inativo, 1 para ativo
}

@Injectable({
  providedIn: 'root'
})
export class ProfessoresService {

  private apiUrl = 'https://localhost:7266/api/professor';

  constructor(private http: HttpClient) { }

  // Método para buscar professores
  getProfessores(): Observable<Professor[]> {
    return this.http.get<Professor[]>(this.apiUrl);
  }
}
