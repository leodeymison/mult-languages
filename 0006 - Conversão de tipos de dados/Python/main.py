
#### ? Conversão implicita
## de int and float
print('CONVERSÃO IMPLICITA')
val1 = 999999999999999                    # 4 bytes = 32 bits   # Converte para float e adiciona 0 nos fracionários
val2 = 999999999999999.999999999999999    # 8 bytes = 64 bits
result = val1 + val2

print(result)

## de boolean para float
flo1 = True               # 2 bytes = 18 bits  # Ele converte em ordem de grandeza. Primeiro ele converte para in que tem 4 bytes e pois para float que tem 8 bytes
flo2 = 12.23              # 8 bytes = 64 bits
result2 = flo1 + flo2
print(result2)

#### ? Conversão explicita
## ? int()
print('\nCONVERSÃO EXPLICITA - int()')
conv1 = int(10)           # = Mesma coisa que => conv1 = 10
conv2 = int(12.1)         #> 12 # Ele perde os números fracionários na conversão
conv3 = int(2 * 12.2)     #> 24
conv4 = int(True)         #> 1 = True = 1 e False = 0
#! conv5 = int('leo')      #> ERROR
conv6 = int('123')        #> 123
conv7 = int('12'+'12')    #> 1212
#! conv8 = int('12+12')    #> ERROR
#! conv9 = int('12.23')    #> ERROR
conv10 = int('000100', 2) #> 4 # Convertendo numeros binários de base 2
conv11 = int('20', 10)    #> 20 # Convertendo numeros decimais (normal)

print(conv2, ' = ', type(conv2))
print(conv3, ' = ', type(conv3))
print(conv4, ' = ', type(conv4))
#! print(conv5, ' = ', type(conv5)) #> ERROR
print(conv6, ' = ', type(conv6))
print(conv7, ' = ', type(conv7))
#! print(conv8, ' = ', type(conv8)) #> ERROR
#! print(conv9, ' = ', type(conv9)) #> ERROR
print(conv10, ' = ', type(conv10))
print(conv11, ' = ', type(conv11))

## ? float()
print('\nCONVERSÃO EXPLICITA - float()')
convf1 = float(23.1)      #> 23.1 # É a mesma coisa que => convf1 = 23.1
convf2 = float(12)        #> 12.0 # Adiciona um valor .0, por é flutuante
convf3 = float('12.2')    #> 12.2
# convf4 = float("1, 23") #! ERROR
convf5 = float('14')      #> 14.0
convf6 = float("1E4")     #> 10000.0

print(convf2, ' = ', type(convf2))
print(convf3, ' = ', type(convf3))
# print(convf4, ' = ', type(convf4))
print(convf5, ' = ', type(convf5))
print(convf6, ' = ', type(convf6))

## ? str() 
print('\nCONVERSÃO EXPLICITA - str()')
str1 = str(1)                          #> '1'
str2 = str(1.2)                        #> '1.2'
str3 = str(2/5)                        #> '0.4'   # 2 divido por 5 e depois converte
str4 = str(10E2)                       #> '1000.0'
str5 = str(12.34E-4)                   #> '0.001234'
str6 = str(True)                       #> 'True'
str7 = str([1, 9, 2])                  #> '[1, 9, 2]'
str8 = str((1, 9, 2))                  #> '(1, 9, 2)'
str9 = str({1: 1, 2: 'Test', 3: 12.2}) #> '(1, 9, 2)'

print(str1, ' = ', type(str1))
print(str2, ' = ', type(str2))
print(str3, ' = ', type(str3))
print(str4, ' = ', type(str4))
print(str5, ' = ', type(str5))
print(str6, ' = ', type(str6))
print(str7, ' = ', type(str7))
print(str8, ' = ', type(str8))
print(str9, ' = ', type(str9))

## ? list() 
print('\nCONVERSÃO EXPLICITA - list()')
list1 = list('Leo')                #> ['L', 'e', '0']
list2 = list((12, 'h', 'w', 23.2)) #> [12, 'h', 'w', 23.2]

print(list1, ' = ', type(list1))
print(list2, ' = ', type(list2))

## ? tuple() 
print('\nCONVERSÃO EXPLICITA - tuple()')
tuple1 = tuple('Leo')                #> ('L', 'e', 'o')
tuple2 = tuple([12, 'l', True, 1.2]) #> (12, 'l', True, 1.2)

print(tuple1, ' = ', tuple1)
print(tuple2, ' = ', tuple2)