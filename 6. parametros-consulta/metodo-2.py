import requests

url = 'https://example.com/products'
params = {
    'category': 'electronics',
    'limit': 10,
    'page': 1,
    'sort': 'price'
}

response = requests.get(url, params=params)
print(response.json())
