const express = require('express');
const app = express();

app.get('/resource', (req, res) => {
    // Simula uma verificação para recurso
    const resource = null; // Suponha que o recurso não foi encontrado
    if (resource) {
        res.status(200).json(resource);
    } else {
        res.status(404).send('Recurso não encontrado');
    }
});

app.use((req, res) => {
    res.status(400).send('Requisição inválida');
});

app.listen(3000, () => {
    console.log('Servidor rodando na porta 3000');
});
