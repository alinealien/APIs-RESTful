import requests

atualizacao_usuario = { "idade": 31 }
response = requests.patch('https://api.exemplo.com/usuarios/1', json=atualizacao_usuario)
print(response.json())
