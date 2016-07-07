#include <stdlib.h>
#include <stdio.h>

int main(int argc, const char * argv[]) {
    FILE *file = fopen(argv[1], "r");
    char line[1024];
    while (fgets(line, 1024, file)) {
        printf("%d\n", __builtin_popcount(atoi(line)));
    }
    return 0;
}
