class myClass:
    def soma(self, *args) -> int:
        response: int = 0
        for item in args:
            response += item

        return response
    

class myClassTwo(myClass):
    name: str = ""
    def __init__(self, name) -> None:
        super().__init__()
        self.name = name

    def media(self, *args) -> int:
        # print(self.name)
        response = 0
        for item in args:
            print("item: {} - ".format(item, response))
            response += item

        return response / len(args)
    
instance = myClassTwo('Pedro')
print(instance.soma(12, 34, 45))
print("Média dos valores: {}".format(instance.media(23, 2, 4)))
