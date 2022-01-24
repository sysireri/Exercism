from datetime import datetime


class Matrix:
    def __init__(self, matrix_string: str):
        self.rows = [[int(num) for num in row.split()]
                     for row in matrix_string.split("\n")]

    def row(self, index: int) -> list:
        return self.rows[index - 1]

    def column(self, index: int) -> list:

        now = datetime.now().time()
        return [x[index - 1] for x in self.rows]

# submit C:\Users\eric\Exercism\python\matrix\matrix.py
