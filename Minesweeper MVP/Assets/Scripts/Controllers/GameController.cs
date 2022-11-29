using JGM.Minesweeper.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JGM.Minesweeper.Controllers
{
    public interface IMinesweeperController
    {
        void StartGame();
    }

    public class MinesweeperController : IMinesweeperController
    {
        private enum State
        {
            Start,
            InGame,
            Dig,
            Flag,
            End
        }

        private State state;

        private IOperationController startController;
        private IOperationController digController;
        private IOperationController flagController;
        private IOperationController endController;

        public MinesweeperController()
        {
            state = State.Start;
            startController = new StartController();
            digController = new DigController();
            flagController = new FlagController();
            endController = new EndController();
        }

        public void StartGame()
        {
            startController.Execute();
        }
    }

    internal class EndController : IOperationController
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class FlagController : IOperationController
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class DigController : IOperationController
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class StartController : IOperationController
    {
        public void Execute()
        {
            var gridBuilderController = new GridBuilderController();
            gridBuilderController.Build();
        }
    }

    public interface IOperationController
    {
        void Execute();
    }

    public interface IGridBuilderController
    {

    }

    public class GridBuilderController
    {
        public GridModel Build()
        {
            return new GridModel();
        }
    }

    public class GameController : MonoBehaviour
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