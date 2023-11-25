# Não pode repetir dados
# São ordenados por quantidade de bytes (boolean=1, int=28, str=6, float=24)
set1 = {1, 2, 3, 12.2, 4, 'We', False}

set1.add(46)
set1.add(4500)
set1.add(450)

set1.remove(2)
print(set1.pop())
print(set1)

set1.clear()
print("Clean: {}".format(set1))


list1 = {1, 2, 3, 4}
list2 = {1, 5, 3, 6, 7, 10}

list4 = list1 | list2
list5 = list4.copy()

print(list4, list5)


### ? add()

### ? clear()

### ? copy()

### ? difference()

### ? difference_update()

### ? discard()

### ? intersection()

### ? intersection_update()

### ? isdisjoint()

### ? issubset()

### ? issuperset()

### ? pop()

### ? remove()

### ? symmetric_difference()

### ? symmetric_difference_update()

union()

update()
