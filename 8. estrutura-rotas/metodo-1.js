const express = require('express');
const app = express();
app.use(express.json());

let users = []; // Banco de dados simulado

app.get('/users', (req, res) => {
    res.json(users);
});

app.post('/users', (req, res) => {
    const user = req.body;
    users.push(user);
    res.status(201).json(user);
});

app.get('/users/:userId', (req, res) => {
    const user = users.find(u => u.id === parseInt(req.params.userId));
    if (user) {
        res.json(user);
    } else {
        res.status(404).send('User not found');
    }
});

app.put('/users/:userId', (req, res) => {
    let user = users.find(u => u.id === parseInt(req.params.userId));
    if (user) {
        Object.assign(user, req.body);
        res.json(user);
    } else {
        res.status(404).send('User not found');
    }
});

app.delete('/users/:userId', (req, res) => {
    users = users.filter(u => u.id !== parseInt(req.params.userId));
    res.status(204).send();
});

app.get('/users/:userId/orders', (req, res) => {
    // Supondo que temos um método para obter pedidos de um usuário
    const orders = getOrdersForUser(req.params.userId);
    res.json(orders);
});

app.post('/users/:userId/orders', (req, res) => {
    const order = req.body;
    // Adiciona o pedido ao usuário
    addOrderToUser(req.params.userId, order);
    res.status(201).json(order);
});

const getOrdersForUser = (userId) => {
    // Função simulada para obter pedidos
    return [];
};

const addOrderToUser = (userId, order) => {
    // Função simulada para adicionar pedido
};

app.listen(3000, () => {
    console.log('Server is running on port 3000');
});
