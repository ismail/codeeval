import sys

with open(sys.argv[1], 'r') as test_cases:
    for test in test_cases:
        l = test.strip().split(" ")
        try:
            elem = min(list(filter(lambda x: l.count(x) == 1 , l)))
            print(l.index(elem)+1)
        except ValueError:
            print(0)
