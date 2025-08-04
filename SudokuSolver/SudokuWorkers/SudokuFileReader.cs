using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.SudokuWorkers
{
    internal class SudokuFileReader
    {

        public int[,] ReadDFile(string filename)
        {
            int[,] sudokuBoard = new int[9, 9];
            try
            {
                var sudokuBoardLines = File.ReadAllLines(filename);
                int row = 0;
                foreach (var line in sudokuBoardLines)
                {
                    string[] lineElements = line.Split('|').Skip(1).Take(9).ToArray();


                    int col = 0;
                    foreach (var lineElement in lineElements)
                    {
                        sudokuBoard[row, col] = lineElement.Equals(" ") ? 0 : Convert.ToInt16(lineElement);
                        col++;
                    }
                    row++;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while reading the file " + ex.Message);
            }
            return sudokuBoard;
        }
    }
}
