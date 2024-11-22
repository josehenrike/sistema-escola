import { Component, OnInit } from '@angular/core';
import { ProfessorService } from './service/professor.service';

@Component({
  selector: 'app-professor',
  templateUrl: './professor.component.html',
  styleUrls: ['./professor.component.css']
})
export class ProfessoresComponent implements OnInit {

  professores: any[] = [];
  loading: boolean = true;

  constructor(private professorService: ProfessorService) { }

  getStatusLabel(status: number): string {
    return status === 1 ? 'Ativo' : 'Inativo';
  }

  ngOnInit(): void {
    this.professorService.getProfessores().subscribe(
      (data) => {
        this.professores = data;
        this.loading = false;
      },
      (error) => {
        console.error('Erro ao carregar professores', error);
        this.loading = false;
      }
    );
  }
}
