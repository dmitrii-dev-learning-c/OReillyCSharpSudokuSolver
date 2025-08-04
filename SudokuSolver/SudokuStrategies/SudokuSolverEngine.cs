using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuSolver.SudokuWorkers;

namespace SudokuSolver.SudokuStrategies
{
    internal class SudokuSolverEngine
    {
        private readonly SudokuBoardStateManager _sudokuBoardStateManager;
        private readonly SudokuMapper _sudokuMapper;

        public SudokuSolverEngine(SudokuBoardStateManager sudokuBoardStateManager, SudokuMapper sudokuMapper)
        {
            _sudokuBoardStateManager = sudokuBoardStateManager;
            _sudokuMapper = sudokuMapper;
        }

        public bool Solve(int[,] sudokuBoard)
        {
            List<ISudokuStrategy> strategies = new List<ISudokuStrategy>()
            {
                new SimpleMarkupStrategy(_sudokuMapper),
                new NakedPairsStrategy(_sudokuMapper)

            };

            var currentState = _sudokuBoardStateManager.GenerateState(sudokuBoard);
            var nextState = _sudokuBoardStateManager.GenerateState(strategies.First().Solve(sudokuBoard));

            while (!_sudokuBoardStateManager.isSolved(sudokuBoard) && currentState != nextState)
            {
                currentState = nextState;
                foreach (var strategy in strategies)
                {
                    nextState = _sudokuBoardStateManager.GenerateState(strategy.Solve(sudokuBoard));
                }

            }
            return _sudokuBoardStateManager.isSolved(sudokuBoard);
        }
    }
}
