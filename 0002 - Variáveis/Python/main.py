#### Retorna o endereço de memória onde está armazenado
name = 'leodeymison'
varPositionMemory = id(name)

#### Tipos de dados
name = 'Leodeymison' # String
year = 2023          # number
value = 12.5         # number float

# name = 23          # Aceita reatribuição
# del name           # Deleta variável

#### Multiplas atribuições
val1 = val2 = val3 = 10

num1, num2, num3 = 12, 23, 40

#### Mudança de endereço de memória
number1 = number2 = 10

number1 = 90

# print(id(number1), id(number2)) # Com econimia de memória

n1 = 10
n2 = 20
# print(id(n1), id(n2)) # Sem economia de memória


#### Escopo de variável
def multiple(num):
    numMultiple = 2
    return num * numMultiple

print(multiple(12))


#### Verificar o tipo da variável
year = 2023
print(type(year))
