from flask import Flask, request, jsonify

app = Flask(__name__)

@app.route('/users', methods=['POST'])
def create_user():
    new_user = request.json
    # Lógica para criar o usuário
    return jsonify({"message": "Usuário criado com sucesso!"}), 201

if __name__ == '__main__':
    app.run(port=5000)
