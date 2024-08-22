from flask import Flask, jsonify

app = Flask(__name__)

# Rota correta com substantivo plural
@app.route('/products', methods=['GET'])
def get_products():
    return jsonify({"message": "Listando todos os produtos"})

# Rota incorreta com verbo
@app.route('/retrieveAllProducts', methods=['GET'])
def retrieve_all_products():
    return jsonify({"message": "Listando todos os produtos"})
