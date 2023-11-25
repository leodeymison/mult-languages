import psycopg2

connection = psycopg2.connect(
    database="django-test",
    host="localhost",
    user="postgres",
    password="admin",
    port="5432"
)

