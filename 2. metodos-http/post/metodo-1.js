fetch('https://api.exemplo.com/usuarios', {
  method: 'POST',
  headers: {
    'Content-Type': 'application/json'
  },
  body: JSON.stringify({ nome: 'João', idade: 30 })
})
.then(response => response.json())
.then(data => console.log(data));
