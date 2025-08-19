# Sudoku Solver

This is a Sudoku solver written in C#.
It can solve easy, medium, and hard Sudoku puzzles using logic-based strategies.
It does not attempt brute force and therefore may not solve extremely difficult or “impossible” puzzles.

## 🔹 How It Works

The solver uses the strategy design pattern. Each solving method is encapsulated in a class that implements the ISudokuStrategy interface. The Sudoku board is repeatedly passed through these strategies until no more progress can be made.

Currently, two strategies are implemented:

### 1. Simple Markup Strategy

Determines possible candidates for each empty cell.

Considers existing numbers in the row, column, and 3×3 block.

Assigns candidates that are valid across all three constraints.

If a cell has only one candidate, that number is placed.

- This handles most easy and medium-level puzzles.

### 2. Naked Pairs Strategy

Identifies two cells in the same row, column, or block that share the same two possible candidates.

Since those numbers must belong to those two cells, they can be eliminated from other cells in that row, column, or block.

This significantly reduces possibilities and helps solve harder puzzles.

- This strategy is especially useful for medium-to-hard puzzles.

### Example:



