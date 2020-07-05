from flask import Flask,render_template

app=Flask(__name__)

class book(object):
    def __init__(self, id, name, price, pub):
        self.id = id
        self.name = name
        self.price = price
        self.pub = pub

@app.route("/")
def show_table():
    label = ["编号","书名","价格（元）","出版社"]

    f = open("book1.txt", encoding='UTF-8-sig')
    lines = f.readlines()
    content = []
    for book in lines:
        list = book.split()
        content.append(list)
    content.pop()
    f.close()

    return render_template("book.html", labels=label, content=content)

if __name__ =='__main__':
    app.run()