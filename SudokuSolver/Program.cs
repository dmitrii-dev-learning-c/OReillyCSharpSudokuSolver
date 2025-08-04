using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuSolver.jaggedarray_example;
using SudokuSolver.linq_example;
using SudokuSolver.stringbuild_example;
using SudokuSolver.SudokuStrategies;
using SudokuSolver.SudokuWorkers;

namespace SudokuSolver
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("String builder example");
            StringBuilderExample stringBuilderExample = new StringBuilderExample();
            stringBuilderExample.Run();
            Console.WriteLine("\n");

            Console.Write("Jagged Array VS Matrix Example");
            JaggedArrAndMatrixExample jaggedArrayExample = new JaggedArrAndMatrixExample();
            jaggedArrayExample.Run();
            Console.WriteLine("\n");


            Console.WriteLine("LINQ Example");
            LINQExampleClass LINQExampleClass = new LINQExampleClass();
            LINQExampleClass.RunLINQExample();
            Console.WriteLine("\n");


            Console.WriteLine("Welcome to the Sudoku Solver: ");
            //ask for UI:
            try
            {
                SudokuMapper sudokuMapper = new SudokuMapper();
                SudokuBoardStateManager sudokuBoardStateManager = new SudokuBoardStateManager();
                SudokuSolverEngine sudokuSolverEngine = new SudokuSolverEngine(sudokuBoardStateManager, sudokuMapper);
                SudokuFileReader sudokuFileReader = new SudokuFileReader();
                SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

                Console.WriteLine("Please Enter the filename containing the Sudoku Puzzle: ");
                var filename = Console.ReadLine();

                //read sukodu file
                var sudokuBoard = sudokuFileReader.ReadDFile(filename);

                //  1. convert sudoku into a matrix
                sudokuBoardDisplayer.Display("Initial State", sudokuBoard);

                //  3. solve sudoku puzzle matrix
                bool isSudokuSolved = sudokuSolverEngine.Solve(sudokuBoard);


                //  2. print sudoku puzzle matrix
                sudokuBoardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(isSudokuSolved ? "You have successfully solved this Sudoku Puzzle": "Unfortunatelly, current algorithms were not enough to solve the current Sudoku Puzzle!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("{0} : {1} ", "Sudoku Puzzle Cannot be solved because there was an error",ex.Message);
                Console.WriteLine(ex.ToString());
            }
          
        }
    }
}
