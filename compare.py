class Aluno:
    def __init__(self, matricula, nome):
        self.matricula = matricula
        self.nome = nome
        
    def __eq__(self, other):
        if isinstance(other, Aluno):
            return self.matricula == other.matricula
        return False


lista = [Aluno(1, "Nome1"), Aluno(2, "Nome2")]

alunoTeste = Aluno(1, "Nome2")

print(lista.index(alunoTeste))