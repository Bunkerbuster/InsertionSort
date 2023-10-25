# Insertion Sort Algorithm

Source : (Java example) [https://www.youtube.com/watch?v=8mJ-OhcfpYg]

![Bubble Sort](bubble-sort.png)

## Table of Contents
- [About](#about)
- [Usage](#usage)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Example](#example)
- [Contributing](#contributing)
- [License](#license)

## About

This repository contains a C# implementation of the Insertion Sort algorithm, along with a sample web application that demonstrates how to use it. It's meant for educational purposes and to demonstrate how the algorithm works.

Insertion Sort is a simple sorting algorithm that builds the final sorted array one item at a time. It is efficient for small datasets but not suitable for large datasets due to its quadratic time complexity. This repository provides a basic implementation of the Insertion Sort algorithm.

## Usage

Bubble Sort is a simple sorting algorithm that can be used to sort arrays of data in ascending or descending order. You can use the provided implementation as a reference or a starting point for your own sorting needs.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

To run this project, you need to have:

- [.NET SDK](https://dotnet.microsoft.com/download) installed.

### Installation

1. Clone this repository to your local machine using your terminal or command prompt:

```bash
git clone [https://github.com/Bunkerbuster/InsertionSort.git]
```

### Example
Here's an example of how to use the Insertion Sort algorithm in C#:

int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

// Sort the array using Insertion Sort
  int[] sortedArray = insertionSort.SortArray(unsortedArray);

```bash

  int n = UnsortedArray.Length;
  for (int i = 1; i < n; i++)
  {
      int key = UnsortedArray[i];
      int j = i - 1;

      while (j >= 0 && UnsortedArray[j] > key)
      {
          UnsortedArray[j + 1] = UnsortedArray[j];
          j--;
      }
      UnsortedArray[j + 1] = key;
 }
```
##Contributing
none

##License
This project is licensed under the Apache License - see the LICENSE file for details.


