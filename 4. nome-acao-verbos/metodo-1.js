const express = require('express');
const app = express();

app.use(express.json());

app.post('/users', (req, res) => {
  const newUser = req.body;
  // Lógica para criar o usuário
  res.status(201).send(`Usuário criado com sucesso!`);
});

app.listen(3000, () => {
  console.log('API rodando na porta 3000');
});
