import { Component, OnInit } from '@angular/core';
import { RelatorioService } from '../relatorio/service/relatorio.service';

@Component({
  selector: 'app-relatorio',
  templateUrl: './relatorio.component.html',
  styleUrls: ['./relatorio.component.css']
})
export class RelatorioComponent implements OnInit {
  dados: any[] = [];

  constructor(private relatorioService: RelatorioService) { }

  getStatusLabel(status: number): string {
    return status === 1 ? 'Ativo' : 'Inativo';
  }

  ngOnInit(): void {
    this.relatorioService.getProfessoresDetalhes().subscribe(
      (data) => {
        this.dados = data;
      },
      (error) => {
        console.error('Erro ao buscar dados:', error);
      }
    );
  }
}
