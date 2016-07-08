package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
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
		var line = scanner.Text()
		var index = 0
		var count = 0

		index = strings.Index(line, ">>-->")
		var pos = 0
		for index != -1 {
			count++
			pos = pos + index + 3
			index = strings.Index(string(line[pos:]), ">>-->")
		}

		index = strings.Index(line, "<--<<")
		pos = 0
		for index != -1 {
			count++
			pos = pos + index + 2
			index = strings.Index(string(line[pos:]), "<--<<")
		}

		fmt.Printf("%d\n", count)
	}
}
