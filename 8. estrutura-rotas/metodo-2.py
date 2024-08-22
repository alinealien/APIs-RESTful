from flask import Flask, request, jsonify

app = Flask(__name__)
users = []  # Banco de dados simulado

@app.route('/users', methods=['GET'])
def get_users():
    return jsonify(users)

@app.route('/users', methods=['POST'])
def create_user():
    user = request.json
    users.append(user)
    return jsonify(user), 201

@app.route('/users/<int:user_id>', methods=['GET'])
def get_user(user_id):
    user = next((u for u in users if u['id'] == user_id), None)
    if user:
        return jsonify(user)
    else:
        return 'User not found', 404

@app.route('/users/<int:user_id>', methods=['PUT'])
def update_user(user_id):
    user = next((u for u in users if u['id'] == user_id), None)
    if user:
        user.update(request.json)
        return jsonify(user)
    else:
        return 'User not found', 404

@app.route('/users/<int:user_id>', methods=['DELETE'])
def delete_user(user_id):
    global users
    users = [u for u in users if u['id'] != user_id]
    return '', 204

@app.route('/users/<int:user_id>/orders', methods=['GET'])
def get_orders(user_id):
    # Supondo que temos um método para obter pedidos de um usuário
    orders = get_orders_for_user(user_id)
    return jsonify(orders)

@app.route('/users/<int:user_id>/orders', methods=['POST'])
def create_order(user_id):
    order = request.json
    # Adiciona o pedido ao usuário
    add_order_to_user(user_id, order)
    return jsonify(order), 201

def get_orders_for_user(user_id):
    # Função simulada para obter pedidos
    return []

def add_order_to_user(user_id, order):
    # Função simulada para adicionar pedido
    pass

if __name__ == '__main__':
    app.run(port=5000)
