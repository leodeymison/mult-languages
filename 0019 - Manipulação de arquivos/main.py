import os

file = open('./text.txt', "w")
file.write("Testando")

file.close()

file2 = open('./text.txt', "r")
print(file2.read())

file2.close()

print(os.getcwd())

os.rename('./text.txt', './rename.txt')
os.remove('./rename.txt')
print('Arquivo excluido')