import { Component, OnInit } from '@angular/core';
import { TurmaService } from '../turma/service/turma.service';

@Component({
  selector: 'app-turma',
  templateUrl: './turma.component.html',
  styleUrls: ['./turma.component.css']
})
export class TurmaComponent implements OnInit {
  turmas: any[] = [];

  constructor(private turmaService: TurmaService) { }

  ngOnInit(): void {
    this.turmaService.getTurmas().subscribe({
      next: (data) => this.turmas = data,
      error: (error) => console.error('Erro ao buscar as turmas:', error)
    });
  }
}
