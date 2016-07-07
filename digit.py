import io
import sys

d = { 
        2 : [2, 4, 8, 6],
        3 : [3, 9, 7, 1],
        4 : [4, 6],
        7 : [7, 9, 3, 1],
        8 : [8, 4, 2, 6],
        9 : [9, 1]
    }

with open(sys.argv[1], 'r') as test_cases:
    for test in test_cases:
        l = test.strip().split(" ")
        num = int(l[0])
        power = int(l[1])
        r = {}

        if num in [5, 6]:
            r[num] = power
        else:
            divider = len(d[num])
            (x,y) = divmod(power, divider)
            
            for i in d[num]:
                r[i] = x
            
            for i in range(0, y):
                r[d[num][i]] += 1

        result = []
        for i in range(0, 10):
            try:
                num = r[i]
            except KeyError:
                num = 0

            result.append("%d: %d" % (i, num))

        print(", ".join(result))
