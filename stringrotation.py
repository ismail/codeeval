from collections import deque
import sys

with open(sys.argv[1], 'r') as test_cases:
    for test in test_cases:
        words = test.strip().split(",")
        word1 = deque(list(words[0]))
        word2 = deque(list(words[1]))

        tmp = word1
        match = False
        
        if len(words[0]) == len(words[1]):
            i = 0
            l = len(words[0])
            while i < l:
                word1.rotate()

                if word1 == word2:
                    match = True
                    break
            
                i += 1

        if match:
            print("True")
        else:
            print("False")
