export interface Professor {
    id: number;
    nome: string;
    disciplina: string;
    sala: string;
    turma: string;
    cpf: string;
    titulacao: string;
    status: number;  // 0 para inativo, 1 para ativo
}
