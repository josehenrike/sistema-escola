import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class RelatorioService {
  private apiUrl = 'https://localhost:7266/api/relatorios';

  constructor(private http: HttpClient) { }

  getProfessoresDetalhes(): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/professores-detalhes`);
  }
}
