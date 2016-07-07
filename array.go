package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
	"sort"
	"strconv"
	"strings"
)

func main() {
	file, err := os.Open(os.Args[1])

	if err != nil {
		log.Fatal(err)
	}
	defer file.Close()

	scanner := bufio.NewScanner(file)
	for scanner.Scan() {
		var m = make(map[int]bool)
		var a = strings.Split(scanner.Text(), ",")
		var l []int

		for i := 0; i < len(a); i++ {
			j, _ := strconv.Atoi(a[i])
			if _, exists := m[j]; !exists {
				l = append(l, j)
			}
			m[j] = true
		}

		sort.Ints(l)
		for i := 0; i < len(l)-1; i++ {
			fmt.Printf("%d,", l[i])
		}

		fmt.Printf("%d\n", l[len(l)-1])
	}
}
