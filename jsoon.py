import json
import sys

with open(sys.argv[1], 'r') as test_cases:
    for test in test_cases:
        total = 0
        if test.strip() == "":
            continue
        l = json.loads(test)
        for item in l["menu"]["items"]:
            if not item:
                continue

            try:
                label = item["label"]
                total += item["id"]
            except KeyError:
                pass
        print(total)
