using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.SudokuStrategies
{
    internal interface ISudokuStrategy
    {
        int[,] Solve(int[,] sudokuBoard);

    }
}
