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

        public BoardModel(int rows, int columns, int minesAmount)
        {
            grid = new int[rows, columns];
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

            StringBuilder boardView = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    boardView.Append(grid[i, j] == 9 ? "* " : grid[i, j].ToString());
                }

                boardView.Append("\n");
            }

            Debug.Log(boardView);
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