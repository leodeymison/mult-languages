print('=' * 30)
print('=> LOOP FOR')
listFor = [10, 23, 34, 42, 344]
for item in listFor:
    print(item)

print('=' * 30)
print('=> LOOP WHILE')
position = 0
while position < 10:
    position += 1
    if(position == 2):
        print(f'Position: {position}', end=' ')
        print('SALTOU')
        continue

    elif(position == 6):
        print(f'Position: {position}', end=' ')
        print('QUEBROU')
        break
    else:
        print(f'Position: {position}', end=' ')
        print('PROCEGUIR')
