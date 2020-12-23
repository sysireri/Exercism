strAlplabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

def is_pangram(sentence) -> bool:
    sentence = sentence.upper()
    
    for ChrCurrent in strAlplabet:

        if ChrCurrent not in sentence:
            return False

    return True


# submit C:\Users\eric\Exercism\python\pangram\pangram.py