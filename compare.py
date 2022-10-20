class Aluno:
    def __init__(self, matricula, nome):
        self.matricula = matricula
        self.nome = nome
        
    def __eq__(self, other):
        if isinstance(other, Aluno):
            return self.matricula == other.matricula
        return False

aluno1 = Aluno(1, "Nome1")
aluno2 = Aluno(2, "Nome2")

lista = [aluno1, aluno2]

alunoTeste = Aluno(2, "Nome2")

print(lista.index(alunoTeste))