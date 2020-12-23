import random
from random import randint
from string import ascii_uppercase

colNames = set()


class Robot:

    def __init__(self):
        self.name = self.generate_name()

    def generate_name(self) -> str:

        name = self.get_robot_name()

        while name in colNames:
            name = self.get_robot_name()

        colNames.add(name)
        return name

    def reset(self):
        self.name = self.generate_name()

    def get_robot_name(self) -> str:
        return "".join([
            random.choice(ascii_uppercase),
            random.choice(ascii_uppercase),
            str(randint(100, 999))
        ])

#submit C:\Users\eric\Exercism\python\robot-name\robot_name.py
