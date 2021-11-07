from flask import Flask, jsonify, request, stream_with_context

app = Flask(__name__)

# 1. send json to flask server
# 2. get json response back
# 3. update the master json on server


@app.route('/', methods=['GET', 'POST'])
def post():
    if (request.method == "POST"):
        response = request.get_json()
        return jsonify({response}), 200
    else:
        return "your message is received!"


@app.route('/send/<message>')
def show_post(message):
    return f'Sent {message}'


@app.route('/calculate/<int:num>')
def calculate_post(num):
    return f'Calculating {num*1000}'


if __name__ == "__main__":
    app.run(debug=True)
