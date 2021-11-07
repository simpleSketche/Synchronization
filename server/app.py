from flask import Flask, jsonify, request, stream_with_context

app = Flask(__name__)

# 1. send json to flask server
# 2. get json response back
# 3. update the master json on server


class Master_branch():
    def __init__(self):
        self.result = {
            "result": 100,
            "Beam_01": {"x": 0, "y": 0, "z": 0},
            "Beam_02": {"x": 0, "y": 0, "z": 0},
            "Beam_03": {"x": 0, "y": 0, "z": 0}
        }

    def push(self, input):
        self.result["result"] = input


class Update_branch():
    def __init__(self):
        self.result = {
            "result": 100,
            "Beam_01": {"x": 0, "y": 0, "z": 0},
            "Beam_02": {"x": 0, "y": 0, "z": 0},
            "Beam_03": {"x": 0, "y": 0, "z": 0}
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
    update_branch.update(num)
    return f'Feeling from the Update branch {update_branch.result}'


@app.route('/pull')
def pull_post():
    return f'Pulling the data: {master_branch.result} from the current Master branch'


@app.route('/push/<int:num>')
def push_post(num):
    master_branch.push(num)
    return f'Pushing the data result:{num} to the current Master branch'


if __name__ == "__main__":
    master_branch = Master_branch()
    update_branch = Update_branch()

    app.run(debug=True)
