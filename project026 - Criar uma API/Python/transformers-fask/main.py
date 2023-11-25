from flask import Flask
from src.routes.routers import routers

app = Flask(__name__)
app.config['SECRET_KEY'] = 'asdadsad'

routers(app)

if __name__ == "__main__":
    app.run(debug=True)