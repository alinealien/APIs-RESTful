fetch('https://api.exemplo.com/usuarios/1', {
  method: 'PATCH',
  headers: {
    'Content-Type': 'application/json'
  },
  body: JSON.stringify({ idade: 31 })
})
.then(response => response.json())
.then(data => console.log(data));
