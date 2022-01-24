STOP = "STOP"
dict_protein = {
    "AUG": "Methionine",
    "UUU": "Phenylalanine",
    "UUC": "Phenylalanine",
    "UUA": "Leucine",
    "UUG": "Leucine",
    "UCU": "Serine",
    "UCC": "Serine",
    "UCA": "Serine",
    "UCG": "Serine",
    "UAU": "Tyrosine",
    "UAC": "Tyrosine",
    "UGU": "Cysteine",
    "UGC": "Cysteine",
    "UGG": "Tryptophan",
    "UAA": STOP,
    "UAG": STOP,
    "UGA": STOP
}


def proteins(strand: str) -> list:
    amino_acids = []
    for i in range(0, len(strand), 3):
        codon = strand[i:i + 3]
        if dict_protein[codon] == STOP:
            break
        amino_acids.append(dict_protein[codon])

    return amino_acids

# submit C:\Users\eric\Exercism\python\protein-translation\protein_translation.py
