from flask import Flask, jsonify, request, stream_with_context

app = Flask(__name__)

# 1. send json to flask server
# 2. get json response back
# 3. update the master json on server


class Master_json():
    def __init__(self):
        self.result = {
            "result": 100
        }

    def update(self, input):
        self.result["result"] = input


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


@app.route('/update/<int:num>')
def update_post(num):
    master_json.update(num)
    return f'Updating the master json result to: {master_json.result["result"]}'


@app.route('/check')
def checck_post():
    return f'Checking the current master json result: {master_json.result}'


if __name__ == "__main__":
    master_json = Master_json()
    app.run(debug=True)
