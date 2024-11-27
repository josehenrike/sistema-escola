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

  professorSelecionado: any = null;

  editarProfessor(professor: any): void {
    this.professorSelecionado = { ...professor };
  }

  atualizarProfessor(): void {
    const index = this.professores.findIndex(p => p.id === this.professorSelecionado.id);
    if (index !== -1) {
      this.professores[index] = { ...this.professorSelecionado };
      alert('Professor atualizado com sucesso!');
    }
    this.professorSelecionado = null;
  }

  cancelarEdicao(): void {
    this.professorSelecionado = null;
  }

  excluirProfessor(id: number): void {
    const confirmacao = confirm('Tem certeza que deseja excluir este professor?');
    if (confirmacao) {
      this.professores = this.professores.filter(p => p.id !== id);
      alert(`Professor com ID ${id} excluído com sucesso!`);
    }
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
