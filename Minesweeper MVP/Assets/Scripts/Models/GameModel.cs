using JGM.Minesweeper.Utils;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor.PackageManager.UI;
using UnityEngine;

namespace JGM.Minesweeper.Models
{
    public class BoardModel
    {
        public enum CellValue
        {
            Empty,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Mine
        }

        private readonly int[,] grid;
        private readonly int minesAmount;

        public int Rows { get; }
        public int Columns { get; }

        public BoardModel(int rows, int columns, int minesAmount)
        {
            grid = new int[rows, columns];
            Rows = rows;
            Columns = columns;
            this.minesAmount = minesAmount;
            var mineCoordinates = new HashSet<Coordinate>();

            while (mineCoordinates.Count < minesAmount)
            {
                int randomRow = Random.Range(0, rows);
                int randomColumn = Random.Range(0, columns);
                var randomCoordinate = new Coordinate(randomRow, randomColumn);
                mineCoordinates.Add(randomCoordinate);
            }

            foreach (var coordinate in mineCoordinates)
            {
                grid[coordinate.Row, coordinate.Column] = (int)CellValue.Mine;
            }

            foreach (var mineCoordinate in mineCoordinates)
            {
                List<Coordinate> neighborsCoordinates = new List<Coordinate>();

                var newCoordinate = new Coordinate(mineCoordinate.Row - 1, mineCoordinate.Column - 1);
                if (IsValidCoordinate(newCoordinate))
                {
                    if (grid[newCoordinate.Row, newCoordinate.Column] != 9)
                    {
                        neighborsCoordinates.Add(newCoordinate);
                    }
                }

                newCoordinate = new Coordinate(mineCoordinate.Row - 1, mineCoordinate.Column);
                if (IsValidCoordinate(newCoordinate))
                {
                    if (grid[newCoordinate.Row, newCoordinate.Column] != 9)
                    {
                        neighborsCoordinates.Add(newCoordinate);
                    }
                }

                newCoordinate = new Coordinate(mineCoordinate.Row - 1, mineCoordinate.Column + 1);
                if (IsValidCoordinate(newCoordinate))
                {
                    if (grid[newCoordinate.Row, newCoordinate.Column] != 9)
                    {
                        neighborsCoordinates.Add(newCoordinate);
                    }
                }

                newCoordinate = new Coordinate(mineCoordinate.Row, mineCoordinate.Column - 1);
                if (IsValidCoordinate(newCoordinate))
                {
                    if (grid[newCoordinate.Row, newCoordinate.Column] != 9)
                    {
                        neighborsCoordinates.Add(newCoordinate);
                    }
                }

                newCoordinate = new Coordinate(mineCoordinate.Row, mineCoordinate.Column + 1);
                if (IsValidCoordinate(newCoordinate))
                {
                    if (grid[newCoordinate.Row, newCoordinate.Column] != 9)
                    {
                        neighborsCoordinates.Add(newCoordinate);
                    }
                }

                newCoordinate = new Coordinate(mineCoordinate.Row + 1, mineCoordinate.Column - 1);
                if (IsValidCoordinate(newCoordinate))
                {
                    if (grid[newCoordinate.Row, newCoordinate.Column] != 9)
                    {
                        neighborsCoordinates.Add(newCoordinate);
                    }
                }

                newCoordinate = new Coordinate(mineCoordinate.Row + 1, mineCoordinate.Column);
                if (IsValidCoordinate(newCoordinate))
                {
                    if (grid[newCoordinate.Row, newCoordinate.Column] != 9)
                    {
                        neighborsCoordinates.Add(newCoordinate);
                    }
                }

                newCoordinate = new Coordinate(mineCoordinate.Row + 1, mineCoordinate.Column + 1);
                if (IsValidCoordinate(newCoordinate))
                {
                    if (grid[newCoordinate.Row, newCoordinate.Column] != 9)
                    {
                        neighborsCoordinates.Add(newCoordinate);
                    }
                }

                foreach (var neighborCoordinate in neighborsCoordinates)
                {
                    grid[neighborCoordinate.Row, neighborCoordinate.Column]++;
                }
            }

            StringBuilder boardView = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    boardView.Append(grid[i, j].ToString());
                }

                boardView.Append("\n");
            }

            Debug.Log(boardView);
        }

        private bool IsValidCoordinate(Coordinate newCoordinate)
        {
            return newCoordinate.Row < Rows && newCoordinate.Row >= 0 && newCoordinate.Column < Columns && newCoordinate.Column >= 0;
        }
    }

    public class GameModel : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}