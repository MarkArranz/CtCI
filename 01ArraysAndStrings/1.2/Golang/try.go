package main

import "fmt"

// Reverse a string
func main() {
	input := []string{"c", "a", "r"}
	fmt.Println("input:")
	for i := 0; i < len(input); i++ {
		fmt.Print(input[i])
	}
	fmt.Println()

	reverse(input)

	fmt.Println("reverse:")
	for i := 0; i < len(input); i++ {
		fmt.Print(input[i])
	}
	fmt.Println()
}

func reverse(str []string) {
	// Initialize start and end indexes
	start := 0
	end := len(str) - 1

	for start < end {
		temp := str[start]
		str[start] = str[end]
		str[end] = temp

		start++
		end--
	}
}
