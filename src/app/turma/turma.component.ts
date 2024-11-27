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

  turmaSelecionada: any = null;

  editarTurma(turma: any): void {
    this.turmaSelecionada = { ...turma };
  }

  atualizarTurma(): void {
    const index = this.turmas.findIndex(t => t.id === this.turmaSelecionada.id);
    if (index !== -1) {
      this.turmas[index] = { ...this.turmaSelecionada };
      alert('Turma atualizada com sucesso!');
    }
    this.turmaSelecionada = null;
  }

  cancelarEdicao(): void {
    this.turmaSelecionada = null;
  }

  excluirTurma(id: number): void {
    const confirmacao = confirm('Tem certeza que deseja excluir esta turma?');
    if (confirmacao) {
      this.turmas = this.turmas.filter(t => t.id !== id);
      alert(`Turma com ID ${id} excluída com sucesso!`);
    }
  }

  ngOnInit(): void {
    this.turmaService.getTurmas().subscribe({
      next: (data) => this.turmas = data,
      error: (error) => console.error('Erro ao buscar as turmas:', error)
    });
  }
}
