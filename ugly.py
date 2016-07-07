import io
import re
import sys

ops = ["+", "-", ""]
perm = None

def genperm (l):
    global perm
    length = len(l)
    count = 0
    
    f = io.StringIO()
    
    if length == 2:
        perm = [[x] for x in ops]
    else:
        print("perm = [ (", end="", file=f)
        for i in range(0, length-2):
            print("x%d, " % i, end="", file=f)
        print("x%d) " % (length-2), end="", file=f)

        for i in range(0, length-1):
            print("for x%d in ops " % i, end="", file=f)
        print("]", end="", file=f)

        exec(f.getvalue(), globals())
  
    for p in perm:
        r = io.StringIO()
        for i in range(0, length-1):
            print("%s%s" % (l[i], p[i]), end="", file=r)
        print("%s" % l[length-1], end="", file=r)
        c = r.getvalue()
        c = re.sub("(\d+)", "int(\"\\1\")", r.getvalue())
        exec("result=%s" % c, globals())

        if isugly(result):
            count += 1
    print(count)

def isugly (x):
    if (x%2 == 0) or (x%3 == 0) or (x%5 == 0) or (x%7 == 0):
        return True

    return False

with open(sys.argv[1], 'r') as test_cases:
    for test in test_cases:
        test = re.sub("^0{1,}","0", test)
        l = [x for x in test.strip()]

        if len(l) == 1:
            if isugly(int(l[0])):
                print(1)
            else:
                print(0)
        else:
            genperm(l)
