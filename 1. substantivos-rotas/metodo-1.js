// Rota correta com substantivo plural
app.get('/users', (req, res) => {
  // Código para obter todos os usuários
  res.send("Listando todos os usuários");
});

// Rota incorreta com verbo
app.get('/getUsers', (req, res) => {
  // Código para obter todos os usuários
  res.send("Listando todos os usuários");
});
