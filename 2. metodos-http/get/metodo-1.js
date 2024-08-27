fetch('https://api.exemplo.com/usuarios')
  .then(response => response.json())
  .then(data => console.log(data));
