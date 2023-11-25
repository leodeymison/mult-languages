def soma(*args) -> int:
    result: int = 0
    for item in args:
        result += item

    return result