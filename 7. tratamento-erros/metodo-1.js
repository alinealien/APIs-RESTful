const express = require('express');
const app = express();

app.get('/resources', (req, res) => {
    // Simula uma verificação para recurso
    const resource = null; // Suponha que o recurso não foi encontrado
    if (resource) {
        res.status(200).json(resource);
    } else {
        res.status(404).json({ error: 'Recurso não encontrado' });
    }
});

// Middleware para capturar rotas inexistentes
app.use((req, res) => {
    res.status(404).json({ error: 'Rota não encontrada' });
});

app.listen(3000, () => {
    console.log('Servidor rodando na porta 3000');
});
