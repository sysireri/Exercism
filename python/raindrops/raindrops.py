def convert(number: int) -> str:

    str_result = ""
    if number % 3 == 0:
        str_result += "Pling"

    if number % 5 == 0:
        str_result += "Plang"

    if number % 7 == 0:
        str_result += "Plong"

    if not str_result:
        str_result = str(number)

    return str_result

# submit C:\Users\eric\Exercism\python\raindrops\raindrops.py
