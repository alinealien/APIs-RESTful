import requests

response = requests.delete('https://api.exemplo.com/usuarios/1')
print(response.json())
