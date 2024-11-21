import { Component, OnInit } from '@angular/core';
import { ProfessoresService } from '../professor/services/professor.service';

interface Professor {
  id: number;
  nome: string;
  disciplina: string;
  sala: string;
  turma: string;
  status: number;  // 0 para inativo, 1 para ativo
}

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  professores: Professor[] = [];

  constructor(private professorService: ProfessoresService) { }

  ngOnInit(): void {
    // Chamando o serviço para obter a lista de professores
    this.professorService.getProfessores().subscribe(
      (data) => {
        this.professores = data;  // Armazenando os dados na variável professores
      },
      (error) => {
        console.error('Erro ao carregar os dados dos professores', error);
      }
    );
  }
}
