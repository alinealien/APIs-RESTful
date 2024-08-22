from flask import Flask, request

app = Flask(__name__)

@app.route('/users/<int:userId>/orders')
def get_orders(userId):
    # Lógica para buscar os pedidos do usuário
    return f"Pedidos do usuário {userId}"

if __name__ == '__main__':
    app.run(debug=True)
