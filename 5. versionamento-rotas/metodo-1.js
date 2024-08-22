const express = require('express');
const app = express();

// Versão 1 da rota /users
app.get('/v1/users', (req, res) => {
    res.json([{ id: 1, name: "John Doe v1" }]);
});

// Versão 2 da rota /users
app.get('/v2/users', (req, res) => {
    res.json([{ id: 1, name: "John Doe v2", email: "john@example.com" }]);
});

app.listen(3000, () => {
    console.log('API rodando na porta 3000');
});
