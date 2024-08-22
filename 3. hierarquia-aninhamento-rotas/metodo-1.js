const express = require('express');
const app = express();

app.get('/users/:userId/orders', (req, res) => {
  const userId = req.params.userId;
  // Lógica para buscar os pedidos do usuário
  res.send(`Pedidos do usuário ${userId}`);
});

app.listen(3000, () => console.log('Servidor rodando na porta 3000'));
