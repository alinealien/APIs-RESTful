const baseUrl = 'https://example.com/products';
const params = new URLSearchParams({
    category: 'electronics',
    limit: 10,
    page: 1,
    sort: 'price'
});

fetch(`${baseUrl}?${params.toString()}`)
    .then(response => response.json())
    .then(data => console.log(data))
    .catch(error => console.error('Error:', error));
