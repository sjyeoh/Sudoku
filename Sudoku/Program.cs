using System;
using System.Collections.Generic;
using System.Linq;
using Sudoku.Solver;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
//			int[,] puzzle = {
//	{ 3, 2, 1, 7, 0, 4, 0, 0, 0 },
//	{ 6, 4, 0, 0, 9, 0, 0, 0, 7 },
//	{ 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//	{ 0, 0, 0, 0, 4, 5, 9, 0, 0 },
//	{ 0, 0, 5, 1, 8, 7, 4, 0, 0 },
//	{ 0, 0, 4, 9, 6, 0, 0, 0, 0 },
//	{ 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//	{ 2, 0, 0, 0, 7, 0, 0, 1, 9 },
//	{ 0, 0, 0, 6, 0, 9, 5, 8, 2 }
//};

			int[,] puzzle = {
	{ 1, 0, 5, 8, 0, 2, 0, 0, 0 },
	{ 0, 9, 0, 0, 7, 6, 4, 0, 5 },
	{ 2, 0, 0, 4, 0, 0, 8, 1, 9 },
	{ 0, 1, 9, 0, 0, 7, 3, 0, 6 },
	{ 7, 6, 2, 0, 8, 3, 0, 9, 0 },
	{ 0, 0, 0, 0, 6, 1, 0, 5, 0 },
	{ 0, 0, 7, 6, 0, 0, 0, 3, 0 },
	{ 4, 3, 0, 0, 2, 0, 5, 0, 1 },
	{ 6, 0, 0, 3, 0, 8, 9, 0, 0 }
};

			if (Solver.Sudoku_1.SolveSudoku(puzzle, 0, 0))
				Solver.Sudoku_1.PrintSudoku(puzzle);
		}
    }
}
