package main

import (
    "time"
	"fmt"
	"testing"
)



//Benchmarking individual functions

func Function(x int) float64 {
	f64 := float64(x)
	f64 = f64 / (1/3)
	f64 = f64 * 34
	return f64 * f64
}

func BenchmarkedFunction(b *testing.B) {
	x := 82
	for i := 0; i < b.N; i++ {
		_ = Function(x)
	}
	for j := 1; j < 1000; j++ {
		x = x * j
	}
}

func main(){
	//To measure execution time of whole program
	start := time.Now()

	//Measuring benchmark of individual function
	br := testing.Benchmark(BenchmarkedFunction)
	fmt.Println(br)

	elapsed := time.Since(start)
	fmt.Println("Program execution time: ", elapsed)
}