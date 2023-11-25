list1 = [1, 'hello', 12.1]

print(list1)
print(list1[0])

list1.append(True)
print(list1)

list1.insert(2, 'Olá')
print(list1)

list1.remove("Olá")
print(list1)

list1.pop(2) # Remove pelo index
print(list1)

del list1[1]
print(list1)

count = 1
for (item) in list1:
    print('Item {}: {}'.format(count, item))
    count += 1


listNumbers = [23, 33, 11, 9, 23, 1, 5600, 2]
listNumbers.sort()

print(listNumbers)

listNumbers2 = [22, 99, 435, 566, 2342, 324242, 223]

listJoin = listNumbers + listNumbers2
listJoin.sort()

print(listJoin)


### ? list.append(obj)

### ? list.clear()

### ? list.copy()

### ? list.count(obj)

### ? list.extend(seq)

### ? list.index(obj)

### ? list.insert(index, obj)
 
### ? list.pop(obj=list[-1])

### ? list.remove(obj)

### ? list.reverse()

### ? list.sort([func])
