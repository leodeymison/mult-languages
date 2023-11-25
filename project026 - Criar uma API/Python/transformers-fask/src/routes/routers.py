from flask import jsonify, render_template
from src.infra.methods import findAll

def routers(app):
    @app.route('/')
    def home():
        return render_template('home.html', transformers=findAll('transformers'))
    
    @app.route('/about')
    def about():
        return render_template('about.html')
    
    @app.route('/api/transformers', methods=['GET'])
    def get_object():
        return jsonify(list)