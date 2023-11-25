name: str = "Hello Python!"

print("""index {} do texto "{}": {}""".format(0, name, name[0]))
print("""index {} do texto "{}": {}""".format(-1, name, name[-1]))

print("""do index {} ao index {} do texto "{}": {}""".format(2, 8, name, name[2: 8]))

print("""do index {} en diante do texto "{}": {}""".format(2, name, name[2:]))

print("""até o index {} do texto "{}": {}""".format(6, name, name[:6]))

nameModify: str = "meu nome"

l1 = list(nameModify)

l1.insert(2, 'J')

s1 = ''.join(l1)

print(s1)


st1 = 'Hello'
st2 = 'World'

response = st1 + " " + st2

print(response)

print(r'Hello\nTest')
print('Hello\nTest')