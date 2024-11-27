import { Component, OnInit } from '@angular/core';
import { SalaService } from '../sala/service/sala.service';

@Component({
  selector: 'app-sala',
  templateUrl: './sala.component.html',
  styleUrls: ['./sala.component.css']
})
export class SalaComponent implements OnInit {
  salas: any[] = [];

  constructor(private salaService: SalaService) { }

  getStatusLabel(status: number): string {
    return status === 1 ? 'Ativo' : 'Inativo';
  }

  salaSelecionada: any = null;

  editarSala(sala: any): void {
    this.salaSelecionada = { ...sala };
  }

  atualizarSala(): void {
    const index = this.salas.findIndex(s => s.id === this.salaSelecionada.id);
    if (index !== -1) {
      this.salas[index] = { ...this.salaSelecionada };
      alert('Sala atualizada com sucesso!');
    }
    this.salaSelecionada = null;
  }

  cancelarEdicao(): void {
    this.salaSelecionada = null;
  }

  excluirSala(id: number): void {
    const confirmacao = confirm('Tem certeza que deseja excluir esta sala?');
    if (confirmacao) {
      this.salas = this.salas.filter(s => s.id !== id);
      alert(`Sala com ID ${id} excluída com sucesso!`);
    }
  }

  ngOnInit(): void {
    this.salaService.getSalas().subscribe({
      next: (data) => this.salas = data,
      error: (error) => console.error('Erro ao buscar as salas:', error)
    });
  }
}
