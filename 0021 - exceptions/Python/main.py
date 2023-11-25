import logging

try:
    value = 'as' + 1
    print('Fluxo normal')
except Exception as error:
    print('Gerou um error: {}'.format(error))
finally:
    print('Executa de qualquer forma')

try:
    raise Exception("Error gerado")
except Exception as error:
    logging.error(' {}'.format(error))