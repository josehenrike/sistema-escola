import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component'; // Componente de Home
import { ProfessoresComponent } from './professor/professor.component'; // Componente de Professores
import { DisciplinaComponent } from './disciplina/disciplina.component';
import { SalaComponent } from './sala/sala.component';
import { TurmaComponent } from './turma/turma.component';

const routes: Routes = [
  { path: '', component: HomeComponent },  // Rota para a Home
  { path: 'professores', component: ProfessoresComponent },  // Rota para Professores
  { path: 'disciplinas', component: DisciplinaComponent },
  { path: 'salas', component: SalaComponent },
  { path: 'turmas', component: TurmaComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
