def soma(n1: int, n2: int = 10) -> int:
    return n1 + n2

print(f'Soma de dois valores: {soma(12, 12)}')

print(f'Soma de um valor valor mais 10: {soma(12)}')

print(f'Soma de um valor nomeado: {soma(n1=10, n2=20)}')

def soma2(*args: tuple) -> int:
    response = 0
    for item in args:
        response += item

    return response

def Multi(*args: tuple) -> int:
    response = 0;
    for item in args:
        response *= item

    return response

print(f'Soma de multiplos valores: {soma2(12, 12, 1, 3, 45, 23)}')

print(f'Soma de 0 valores: {soma2()}')

myFunc = soma2

print(f'Passando function para variável: {myFunc(10, 12, 23)}')



print('\n# Argumentos arbritários')

def test(port: int, english: int, **multiples: dict[str, int]) -> any:
    print("Português: {}".format(port))
    print("English: {}".format(english))

    soma: int = 0
    for x, item in multiples.items():
        soma += item
        print("{}: {}".format(x, item))

test(port=10, english=9, Matemática=8, Geografia='1')