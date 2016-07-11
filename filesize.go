package main

import (
	"fmt"
	"log"
	"os"
)

func main() {
	file, err := os.Open(os.Args[1])

	if err != nil {
		log.Fatal(err)
	}
	defer file.Close()

	info, _ := file.Stat()
	fmt.Printf("%d", info.Size())
}
