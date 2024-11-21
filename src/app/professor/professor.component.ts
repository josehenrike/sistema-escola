import { Component, OnInit } from '@angular/core';
import { ProfessoresService } from '../professor/services/professor.service';

interface Professor {
  id: number;
  nome: string;
  disciplina: string;
  sala: string;
  turma: string;
  status: number;
}

@Component({
  selector: 'app-professores',
  templateUrl: './professor.component.html',
  styleUrls: ['./professor.component.css']
})
export class ProfessoresComponent implements OnInit {
  professores: Professor[] = [];

  constructor(private professorService: ProfessoresService) { }

  ngOnInit(): void {
    this.professorService.getProfessores().subscribe(
      (data) => {
        this.professores = data;
      },
      (error) => {
        console.error('Erro ao carregar os professores', error);
      }
    );
  }
}
