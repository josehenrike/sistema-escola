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

  getStatusLabel(status: number): string {
    return status === 1 ? 'Ativo' : 'Inativo';
  }

  disciplinaSelecionada: any = null;

  editarDisciplina(disciplina: any): void {
    this.disciplinaSelecionada = { ...disciplina };
  }

  atualizarDisciplina(): void {
    const index = this.disciplinas.findIndex(d => d.id === this.disciplinaSelecionada.id);
    if (index !== -1) {
      this.disciplinas[index] = { ...this.disciplinaSelecionada };
      alert('Disciplina atualizada com sucesso!');
    }
    this.disciplinaSelecionada = null;
  }

  cancelarEdicao(): void {
    this.disciplinaSelecionada = null;
  }

  excluirDisciplina(id: number): void {
    const confirmacao = confirm('Tem certeza que deseja excluir esta disciplina?');
    if (confirmacao) {
      this.disciplinas = this.disciplinas.filter(d => d.id !== id);
      alert(`Disciplina com ID ${id} excluída com sucesso!`);
    }
  }

  ngOnInit(): void {
    this.loadDisciplinas();
  }

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
