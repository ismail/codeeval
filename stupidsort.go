package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
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
		l := strings.Split(scanner.Text(), "|")
		numberstring := strings.Split(strings.TrimSpace(l[0]), " ")
		length := len(numberstring)
		count, _ := strconv.Atoi(strings.TrimSpace(l[1]))
		numbers := make([]int, length)

		for i := 0; i < length; i++ {
			numbers[i], _ = strconv.Atoi(numberstring[i])
		}

		for i := 0; i < count; i++ {
			for j := 0; j < length-2; j++ {
				if numbers[j] > numbers[j+1] {
					t := numbers[j]
					numbers[j] = numbers[j+1]
					numbers[j+1] = t
					break
				}
			}
		}

		for i := 0; i < length-1; i++ {
			fmt.Printf("%d ", numbers[i])
		}
		fmt.Printf("%d \n", numbers[length-1])
	}
}
