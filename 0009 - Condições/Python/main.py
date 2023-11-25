
### ? if, elif and else
value = 18
if value < 16:
    print(f'{value} é menor de idade')
elif value >= 16 and value < 18:
    print(f'Com {value} só tem direito de votar')
else:
    print(f'{value} é maior de idade')

print("" * 30)

### ? Match-Case (switch case)
position = 'top'
match position:
    case 'top' | 'low':
        print('Eixo Y')
    case 'lefth' | 'rigth':
        print('Eixo X')

# ? In list
def funListCase(listC):
    match listC:
        case [age, name] if age >= 18:
            print(f'{name} tem {age} anos, LIBERADO!') 
        case [age, *names] if age >= 18:
            for name in names:
                print(f'{name} tem {age} anos, LIBERADO!')

        case [age, name] if age < 18:
            print(f'{name} tem {age} anos, RECUSADO!')
        case [age, *names] if age < 18:
            for name in names:
                print(f'{name} tem {age} anos, RECUSADO!')

        case _:
            print('Opções inválidas!')

funListCase([18, 'Carlos'])
funListCase([12, 'Bianca'])
funListCase([20, 'Carlos'])
funListCase([21, 'Ana carolia', 'Joana', 'Estéfane', 'Carlos A.', 'Pedrovisca'])
