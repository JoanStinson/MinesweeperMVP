using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JGM.Minesweeper.Utils
{
    public class Constraint
    {
        private int minRow;
        private int maxRow;
        private int minColumn;
        private int maxColumn;

        public Constraint()
        {

        }
    }

    public class Coordinate
    {
        public int Row { get; }
        public int Column { get; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }

    public class Utils : MonoBehaviour
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
