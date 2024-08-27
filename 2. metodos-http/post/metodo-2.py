import requests

novo_usuario = { "nome": "João", "idade": 30 }
response = requests.post('https://api.exemplo.com/usuarios', json=novo_usuario)
print(response.json())
