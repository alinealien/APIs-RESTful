from flask import Flask, jsonify

app = Flask(__name__)

# Versão 1 da rota /users
@app.route('/v1/users', methods=['GET'])
def get_users_v1():
    return jsonify([{'id': 1, 'name': 'John Doe v1'}])

# Versão 2 da rota /users
@app.route('/v2/users', methods=['GET'])
def get_users_v2():
    return jsonify([{'id': 1, 'name': 'John Doe v2', 'email': 'john@example.com'}])

if __name__ == '__main__':
    app.run(port=5000)
