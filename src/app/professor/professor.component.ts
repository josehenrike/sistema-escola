import { Component, OnInit } from '@angular/core';
import { ProfessorService } from 'src/app/professor/services/professor.service';

@Component({
  selector: 'app-professor',
  templateUrl: './professor.component.html',
  styleUrls: ['./professor.component.css'],
})
export class ProfessorComponent implements OnInit {
  professores: any[] = []; // Lista para armazenar dados do backend

  constructor(private professorService: ProfessorService) { }

  ngOnInit(): void {
    this.professorService.getProfessores().subscribe({
      next: (data) => {
        console.log('Dados recebidos do backend:', data);
        this.professores = data; // Salva os dados retornados
      },
      error: (err) => {
        console.error('Erro ao buscar dados do backend:', err);
      },
    });
  }
}
