import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ProfessoresComponent } from './professor/professor.component';
import { HomeComponent } from './home/home.component';
import { NavComponent } from './nav/nav.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DisciplinaComponent } from './disciplina/disciplina.component';
import { SalaComponent } from './sala/sala.component';
import { TurmaComponent } from './turma/turma.component';
import { RelatorioComponent } from './relatorio/relatorio.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    ProfessoresComponent,
    HomeComponent,
    NavComponent,
    DisciplinaComponent,
    SalaComponent,
    TurmaComponent,
    RelatorioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
