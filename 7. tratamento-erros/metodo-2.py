from flask import Flask, jsonify, abort

app = Flask(__name__)

@app.route('/resource')
def get_resource():
    resource = None  # Suponha que o recurso não foi encontrado
    if resource:
        return jsonify(resource), 200
    else:
        abort(404, description="Recurso não encontrado")

@app.errorhandler(400)
def bad_request(error):
    return str(error), 400

if __name__ == '__main__':
    app.run(port=3000)
