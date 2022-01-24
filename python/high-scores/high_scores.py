def latest(scores: list) -> int:
    return scores[-1] if scores else None


def personal_best(scores: list) -> int:
    return max(scores) if scores else None


def personal_top_three(scores: list) -> list:
    return sorted(scores, reverse=True)[:3]

# exercism submit  C:\Users\eric\Exercism\python\high-scores\high_scores.py
