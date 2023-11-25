from urllib.request import urlopen
obj = urlopen("https://www.tutorialspoint.com/static/images/simply-easy-learning.jpg")
data = obj.read()
img = open("img.jpg", "wb")
img.write(data)
img.close()