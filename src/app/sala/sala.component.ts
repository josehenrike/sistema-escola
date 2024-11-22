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

  ngOnInit(): void {
    this.salaService.getSalas().subscribe({
      next: (data) => this.salas = data,
      error: (error) => console.error('Erro ao buscar as salas:', error)
    });
  }
}
