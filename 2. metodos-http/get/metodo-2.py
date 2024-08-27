#import requests

#response = requests.get('https://api.exemplo.com/usuarios')
#print(response.json())


from flask import Flask, request, jsonify

app = Flask(__name__)

users = []

@app.route('/users', methods=['GET'])
def get_users():
    return jsonify(users), 200

@app.route('/users', methods=['POST'])
def add_user():
    new_user = request.get_json()
    users.append(new_user)
    return jsonify(new_user), 201

if __name__ == '__main__':
    app.run(debug=True)
