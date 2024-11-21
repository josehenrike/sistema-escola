import { Component, OnInit } from '@angular/core';
import { DisciplinaService } from './service/disciplina.service';

@Component({
  selector: 'app-disciplina',
  templateUrl: './disciplina.component.html',
  styleUrls: ['./disciplina.component.css']
})
export class DisciplinaComponent implements OnInit {

  disciplinas: any[] = [];
  constructor(private disciplinaService: DisciplinaService) { }

  ngOnInit(): void {
    this.loadDisciplinas();
  }

  // Método para buscar as disciplinas
  loadDisciplinas(): void {
    this.disciplinaService.getDisciplinas().subscribe(
      (data) => {
        this.disciplinas = data;
      },
      (error) => {
        console.error('Erro ao carregar as disciplinas', error);
      }
    );
  }
}
