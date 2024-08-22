fetch('https://api.exemplo.com/usuarios/1', {
    method: 'DELETE'
  })
  .then(response => response.json())
  .then(data => console.log(data));
  