# from src.main.config.connectionDB import connection

listTransformers = [
    {
        'id': 1,
        'name': 'bumblebee',
        'image': 'https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/4ecf6bb3-e5c2-49aa-8300-365ddf7e83fa/devhf3p-2dd96922-6f63-450d-8af0-91c603ebd010.png/v1/fill/w_1280,h_1572/bumblebee_png_1_by_kevingame_2_devhf3p-fullview.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTU3MiIsInBhdGgiOiJcL2ZcLzRlY2Y2YmIzLWU1YzItNDlhYS04MzAwLTM2NWRkZjdlODNmYVwvZGV2aGYzcC0yZGQ5NjkyMi02ZjYzLTQ1MGQtOGFmMC05MWM2MDNlYmQwMTAucG5nIiwid2lkdGgiOiI8PTEyODAifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.nDglPcLGpi0nnlQdu3HBP1t704gCPXtJFq7-GGcYBX8',
        'description': 'My name is bumblebee...'
    },
    {
        'id': 2,
        'name': 'Otimus prime',
        'image': 'https://static3.tcdn.com.br/img/img_prod/460977/boneco_optimus_prime_transformers_o_ultimo_cavaleiro_the_last_knight_escala_1_6_threea_apenas_venda__42094_1_20201211173002.png',
        'description': 'My name is Otimus prime...'
    }
]

def findAll(table):
    return listTransformers
    # cursor = connection.cursor()
    # cursor.execute("SELECT * FROM {}".format(table))
    # response = cursor.fetchall()

    # def formatReponse(tupla):
    #     name, image, description = tupla
    #     return {
    #         'name': name,
    #         'image': image,
    #         'description': description
    #     }
    
    # return list(map(formatReponse, response))
